using EnterpriseHRMS.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
namespace EnterpriseHRMS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmployeeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public ActionResult Index(string searchstring)
        {
            var employees = db.Employees.Where(e => !e.IsDeleted);

            if (!string.IsNullOrEmpty(searchstring))
            {
                employees = employees.Where(e =>
                    e.EmpFullName.Contains(searchstring) ||
                    e.Email.Contains(searchstring) ||
                    e.Department.Contains(searchstring)
                );
            }

            return View(employees.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                /*employee.UserId = User.Identity.GetUserId();*/
                employee.CreatedBy = "Admin";
                employee.CreatedDate = DateTime.Now;
                employee.IsDeleted = false;

                db.Employees.Add(employee);
                db.SaveChanges();
                var User=new ApplicationUser
                {
                    UserName = employee.Email,
                    Email = employee.Email
                };
                string defaultPassword = "Password@123";
                var result = await UserManager.CreateAsync(User, defaultPassword);
                if (result.Succeeded) {
                    await UserManager.AddToRoleAsync(User.Id,employee.Role);
                    employee.UserId = User.Id;
                    db.SaveChanges();
                    SendEmployeeCredentials(employee.Email, defaultPassword);
                }


                return RedirectToAction("Index");
            }

            return View(employee);
        }
        public void SendEmployeeCredentials(string email, string password)
        {
            try { 
             MailMessage message = new MailMessage();
                message.From = new MailAddress("udaykirangadari2018@gmail.com", "Enterprise HRMS");
                message.To.Add(email);
                message.Subject = "Welcome to Enterprise HRMS";
                message.Body = "Welcome to Enterprise HRMS\n\n" +
                    "Email:" + email + "\n" + "Temporary Password" +password+ "Please change Your password after login";
                message.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("udaykirangadari2018@gmail.com", "pkhfzqwndlkxetdx");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return HttpNotFound();

            var employee = db.Employees.Find(id);

            if (employee == null)
                return HttpNotFound();

            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                var existingEmployee = db.Employees.Find(employee.Id);

                if (existingEmployee == null)
                    return HttpNotFound();

                existingEmployee.EmpFullName = employee.EmpFullName;
                existingEmployee.Email = employee.Email;
                existingEmployee.Department = employee.Department;
                existingEmployee.JoiningDate = employee.JoiningDate;

                existingEmployee.ModifiedBy = User.Identity.Name;
                existingEmployee.ModifiedDate = DateTime.Now;

                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(employee);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return HttpNotFound();

            var employee = db.Employees.Find(id);

            if (employee == null)
                return HttpNotFound();

            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var employee = db.Employees.Find(id);

            if (employee == null)
                return HttpNotFound();

            employee.IsDeleted = true;
            employee.ModifiedBy = User.Identity.Name;
            employee.ModifiedDate = DateTime.Now;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}