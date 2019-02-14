using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
   public class Book
    {
        private const string ParamName = "year must be between 1100 and 2015";
        #region Attribues
        private string _title;
        private int _year;
        #endregion

        #region Properties

        public string Title
        {
            get { return _title;}
            // set the attribute values
            set
            {
                CheckTitle(value);
                _title = value;
            }
        }
        public int Year
        {
            get { return _year; }
            // set the attribute values
            set
            {
                CheckYear(value);
                _year = value;
            }
        }
        #endregion

        #region Constructor

        public Book()
        {
            
        }
        public Book(string title, int year)
        {
            CheckTitle(title);
            CheckYear(year);
            // set the attribute values
            _title = title;
            _year = year;
        }
        #endregion

        #region CheckingMethods

        public void CheckTitle(string title)
        {
            if (!string.IsNullOrEmpty(title) && title.Length < 2)
            {
                throw  new ArgumentException("Not less than 2 characters eligible");
            }
        }

        public void CheckYear(int year)
        {
            if ((year < 1100) || (year > 2015))
            {
                throw new ArgumentOutOfRangeException(ParamName);
            }
        }

        #endregion
    }
}
