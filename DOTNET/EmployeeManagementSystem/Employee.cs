namespace EMP;

public class Employee{
    private int id;
    private string firstName;
    private string lastName;
    private string email;
    private string contact;
    private double baseSalary;

    public Employee(){}
    public Employee(int id,string firstName,string lastName,string email,string contact,double baseSalary)
    {
        this.id=id;
        this.firstName=firstName;
        this.lastName=lastName;
        this.email=email;
        this.contact=contact;
        this.baseSalary=baseSalary;
    }
    public int ID{
        get{return this.id;}
        set{this.id=value;}
    }
    public string FirstName{
        get{return this.firstName;}
        set{this.firstName=value;}
    }
    public string LastName{
        get{return this.lastName;}
        set{this.lastName=value;}
    }
    public string Email{
        get{return this.email;}
        set{this.email=value;}
    }
    public string Contact{
        get{return this.contact;}
        set{this.contact=value;}
    }
    public double BaseSalary{
        get{return this.baseSalary;}
        set{this.baseSalary=value;}
    }

    public override string ToString()
    {
        return this.id+" "+this.firstName+" "+this.lastName+" "+this.email+" "+this.contact+" "+this.baseSalary; 
    }
    ~Employee(){
        
    }
}