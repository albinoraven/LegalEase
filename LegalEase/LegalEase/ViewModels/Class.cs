using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LegalEase.Models;

namespace LegalEase.ViewModels
{
    public class AddUserViewModel : User
    {
        public string Verify { get; set; }
    }
}
