using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TreinamentoWeb.Models
{
    public class Login
    {
        [Display(Name = "username", ResourceType = typeof(Resources.Strings))]
        [Required(ErrorMessageResourceType =typeof(Resources.Strings), ErrorMessageResourceName = "required")]
        [RegularExpression(@" ^ (([A - Za - z0 - 9] + _ +) | ([A - Za - z0 - 9] +\-+)|([A-Za-z0-9]+\.+)|([A-Za-z0-9]+\++))*[A-Za-z0-9]+@((\w+\-+)|(\w+\.))*\w{1,63}\.[a-zA-Z]{2,6}$")]
        public string Username { get; set; }

        [Display(Name = "password", ResourceType = typeof(Resources.Strings))]
        [Required(ErrorMessageResourceType = typeof(Resources.Strings), ErrorMessageResourceName = "required")]
        public string Password { get; set; }

    }
}