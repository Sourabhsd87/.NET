using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerse
{
    public class Dashboard : IOrderDetails, ICustomerDetails
    {
        #region Data members
        private int FinancialYear;
        private string Department;
        private bool DisposedValue;
        #endregion

        #region getters n setters
        public int financialYear
        {
            get { return this.FinancialYear; }
            set { this.FinancialYear = value; }
        }
        public string department
        {
            get { return this.Department; }
            set { this.Department = value; }
        }
        public bool disposedValue
        {
            get { return this.DisposedValue; }
            set { this.DisposedValue = value; }
        }
        #endregion

        #region ctors
        public Dashboard() { }
        public Dashboard(int FinancialYear,string Department,bool DisposedValue)
        {
            this.FinancialYear=FinancialYear;
            this.Department=Department;
            this.DisposedValue=DisposedValue;
        }
        #endregion

        #region Implemented Methods
        void IOrderDetails.ShowDetails()
        {
            Console.WriteLine("Showing Order Details.......");
        }

        void ICustomerDetails.ShowDetails()
        {
            Console.WriteLine("Showing Customer Details.........");
        }
        #endregion

        #region dtor
        ~Dashboard() { }
        #endregion

        public override string ToString()
        {
            return this.FinancialYear+" | "+this.department+" | "+this.DisposedValue;
        }
    }
}
