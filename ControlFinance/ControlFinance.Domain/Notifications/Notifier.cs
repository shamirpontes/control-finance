using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFinance.Domain.Notifications 
{
    public class Notifier 
    {

        public Notifier()
        {
            Notifications = new List<Notifier>();
        }

        [NotMapped]

        public string PropertyName { get; set; }

        [NotMapped]

        public string Message { get; set; }

        [NotMapped]

        public List<Notifier> Notifications { get; set; }


        public bool ValidarPropriedade<T>(T value, string PropertyName) 
        {
            if (value == null || (value is string && string.IsNullOrWhiteSpace(value as string)) || string.IsNullOrWhiteSpace(PropertyName)) 
            {
                Notifications.Add(new Notifier
                {
                    Message = "Required Field",
                    PropertyName = PropertyName
                });

                return false;
            }

            return true;
        }
    }
}
