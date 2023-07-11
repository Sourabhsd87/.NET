namespace complex;

public class Complex{
    private int real;
    private int imag;

    public Complex(){}
    public Complex(int real, int imag){
        this.real = real;
        this.imag = imag;
    }

    public int Real{
        get{return this.real;}
        set{this.real = value;}
    }    
    public int Imag{
        get{return this.imag;}
        set{this.imag = value;}
    }
    public override string ToString(){
        return "|"+this.real+"|"+this.imag+")";
    }
    ~Complex(){

    }

    public static Complex operator+(Complex a, Complex b){
        Complex temp=new Complex();
        temp.real=a.real+b.real;
        temp.imag=a.imag+b.imag;
        return temp;
    }
}