using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Web;

namespace WebServer_.Controllers
{
    public class EmploeesController : ApiController
    {
        DBConnect.ApplicationContext db = null;
        public EmploeesController()
        {
            db = new DBConnect.ApplicationContext();
        }


        [Route("api/employees/create")]
        [AcceptVerbs("POST")]
        [HttpPost]
        public string CreateEmploee()
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            try
            {
                var c = HttpContext.Current;
                DBConnect.Models.Employee emp = new DBConnect.Models.Employee();
                emp.Name = c.Request["name"];
                emp.Surname = c.Request["surname"];
                emp.Phone = c.Request["phone"];
                emp.Sex = c.Request["sex"];
                emp.DateOfBirth = Convert.ToInt32(c.Request["date_of_birthday"]);
                emp.Age = Convert.ToInt32(c.Request["age"]);
                emp.Email = c.Request["email"];
                db.Employees.Add(emp);
                db.SaveChanges();
            }
            catch {
                values.Add("state", "101");
                values.Add("message", "server add error");
                return JsonConvert.SerializeObject(values);
            }
            values.Add("state", "100");
            values.Add("message", "ok");
            return JsonConvert.SerializeObject(values);
        }

        [Route("api/employees/delete")]
        [AcceptVerbs("POST")]
        [HttpPost]
        public string DeleteEmploee()
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            try
            {
                var c = HttpContext.Current;
                DBConnect.Models.Employee emp = db.Employees.Find(Convert.ToInt32( c.Request["id"]));
                emp.IsDeleted = 1;
                db.Entry(emp).CurrentValues.SetValues(emp);
                db.SaveChanges();
            }
            catch
            {
                values.Add("state", "101");
                values.Add("message", "server delete error");
                return JsonConvert.SerializeObject(values);
            }
            values.Add("state", "100");
            values.Add("message", "ok");
            return JsonConvert.SerializeObject(values);
        }

        [Route("api/employees/get-all")]
        [HttpGet]
        public List<Dictionary<string, object>> GetAllEmployees()
        {
            List<Dictionary<string, object>> values = new List<Dictionary<string, object>>();
            try
            {
                IQueryable<DBConnect.Models.Employee> AllEmps = db.Employees;
                foreach (DBConnect.Models.Employee item in AllEmps)
                {
                    Dictionary<string, object> emp = new Dictionary<string, object>();
                    if (item.IsDeleted != 1)
                    {
                        emp.Add("id", item.Id);
                        emp.Add("name", item.Name);
                        emp.Add("surname", item.Surname);
                        emp.Add("phone", item.Phone);
                        emp.Add("sex", item.Sex);
                        emp.Add("email", item.Email);
                        DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                        dtDateTime = dtDateTime.AddSeconds(item.DateOfBirth).ToLocalTime();
                        emp.Add("date_of_birth", dtDateTime.Date.ToShortDateString()); emp.Add("age", item.Age);
                        values.Add(emp);
                    }
                }
            }
            catch
            {
                values.Clear();
                Dictionary<string, object> err = new Dictionary<string, object>();
                err.Add("state", "101");
                err.Add("message", "server get all error");
                values.Add(err);
                return values;
            }
            return values;
        }

        [Route("api/employees/find")]
        [HttpPost]
        public List<Dictionary<string, object>> FindEmployees()
        {
            var c = HttpContext.Current;
            List<Dictionary<string, object>> values = new List<Dictionary<string, object>>();
            try
            {
                var AllEmps = (from oData in db.Employees select oData).ToList();
                if (!string.IsNullOrEmpty(c.Request["name"]))
                    AllEmps = AllEmps.Where(m => m.Name.Contains(c.Request["name"])).ToList();
                if (!string.IsNullOrEmpty(c.Request["phone"]))
                    AllEmps = AllEmps.Where(m => m.Phone.Contains(c.Request["phone"])).ToList();
                if (!string.IsNullOrEmpty(c.Request["age"]))
                    AllEmps = AllEmps.Where(m => m.Age.Equals(Convert.ToInt32(c.Request["age"]))).ToList();
                if (!string.IsNullOrEmpty(c.Request["sex"]))
                    AllEmps = AllEmps.Where(m => m.Sex.Equals(c.Request["sex"])).ToList();
                if (c.Request["date_of_birth"] != "0")
                    AllEmps = AllEmps.Where(m => m.DateOfBirth.Equals(Convert.ToInt32(c.Request["date_of_birth"]))).ToList();
                if (!string.IsNullOrEmpty(c.Request["surname"]))
                    AllEmps = AllEmps.Where(m => m.Surname.Contains(c.Request["surname"])).ToList();
                if (!string.IsNullOrEmpty(c.Request["email"]))
                    AllEmps = AllEmps.Where(m => m.Email.Contains(c.Request["email"])).ToList();
                foreach (var item in AllEmps)
                { 
                    Dictionary<string, object> emp = new Dictionary<string, object>();
                    if (item.IsDeleted != 1)
                    {
                        emp.Add("id", item.Id);
                        emp.Add("name", item.Name);
                        emp.Add("surname", item.Surname);
                        emp.Add("phone", item.Phone);
                        emp.Add("sex", item.Sex);
                        emp.Add("email", item.Email);
                        DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                        dtDateTime = dtDateTime.AddSeconds(item.DateOfBirth).ToLocalTime();
                        emp.Add("date_of_birth", dtDateTime.Date.ToShortDateString());
                        emp.Add("age", item.Age);
                        values.Add(emp);
                    }
                }
            }
            catch
            {
                List<Dictionary<string, object>> retErr = new List<Dictionary<string, object>>();
                Dictionary<string, object> err = new Dictionary<string, object>();
                err.Add("state", "101");
                err.Add("message", "server find error");
                retErr.Add(err);
                return retErr;
            }
            return values;
        }

        [Route("api/emploees/validate")]
        [HttpGet]
        public int ValidateServer()
        {
            return 1;
        }
    }
}