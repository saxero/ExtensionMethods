namespace ExtensionMethods{
public class MyClass
    {
        protected int count = 1000;
        public void AddOne()
        {
            count++;
        }

        public int GetCount()
        {
            return count;
        }
    }

    public static class MyExtensions2 
    {
        public static string GetNumberWithCurrency(this MyClass myclass, string currency)
        {
            return myclass.GetCount() + currency;
        }
        public static string GetPluMinus(this MyClass myClass)
        {
            if (myClass.GetCount() >=0)
            {
                return "+" + myClass.GetCount().ToString();
            }
            else{
                return "-" + myClass.GetCount();
            }
        }
    } 

   
}