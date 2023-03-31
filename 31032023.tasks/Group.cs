using System;
using System.Collections.Generic;
using System.Text;

namespace _31032023.tasks
{
    internal class Group
    {
        private string _no;
        public string No
        {
            get => this._no;
            set
            {
                int upperCount = 0;
                int digitCount = 0;

                foreach (var item in value)
                {
                    if (char.IsUpper(item))
                        upperCount++;
                    else if (char.IsDigit(item))
                        digitCount++;

                    if (!string.IsNullOrWhiteSpace(value) && upperCount == 2 && digitCount == 3)
                        this._no = value;
                }


            }
        }
        public int StudentLimit { get; set; }

        public string GetInfo()
        {
            return $"No : {No} - StudentLimit : {StudentLimit}";
        }

    }
}
