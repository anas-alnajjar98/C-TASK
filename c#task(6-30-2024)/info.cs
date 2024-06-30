using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace c_task_6_30_2024_
{
    internal class info
    {
        public int age {
            set {
                if (value >= 18 && value <= 60) {
                age = value;
                }
                else
                {
                    throw new ArgumentException("age must be between 18 and 60");
                }
            
            }
            get { return age; } }
        public string Gender;
        public string Name;
        public string Email;
        public string Phone {
            set {
               

                    if (Regex.IsMatch(value, @"^(077|078|079)\d{7}$"))
                    {
                        Phone = value;
                    }
                    else {
                    throw new ArgumentException("number should start 077 or 078 or 079");
                }
                    
                
                
            }
            get { return Phone; }
        }
        public string id;
    }
}
