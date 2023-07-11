namespace MGR;
using EMP;

public class Manager:Employee{
    private double incentives;
    public Manager() { }
    public Manager(int id,string firstName,string lastName,string email,string contact,double baseSalary,double incentives):base(id, firstName, lastName,email, contact, baseSalary) {
        this.incentives = incentives;
    }
    public double Incentives {
        get { return this.incentives; }
        set { this.incentives = value; }
    }
    public override string ToString() {
        return base.ToString() + " ,incentives= " +  this.Incentives;
    }
}

