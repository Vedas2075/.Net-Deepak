public class ExceptionHandling
{
    public double Compute(double x, double y, double z)
    {
       
        double c = 0;
        try
        {
            if( x == 0 || y ==0)
                throw new Exception("Parameter value 0 supplied on x or y");
                
            double value = (x + y) / z ;
            c = value * x / (y + z) ;
        }
        catch(ArithmeticException e)
        {
            Console.WriteLine(e.Message);
            // Console.WriteLine(e.StackTrace);  for using specific error code
        }    
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if(c==20)
                c = 20;
        }

        return c;

    }

    public void Test()
    {
        var v = Compute(23, 45, 0);
    }
}