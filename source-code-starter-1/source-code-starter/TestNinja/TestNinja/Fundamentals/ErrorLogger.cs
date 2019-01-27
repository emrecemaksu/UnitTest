
using System;

namespace TestNinja.Fundamentals
{
    public class ErrorLogger
    {
        public string LastError { get; set; }
        //Guid benzersiz değerler oluşturur.
        public event EventHandler<Guid> ErrorLogged; 
        
        public void Log(string error)
        {
            if (String.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();
                
            LastError = error; 
            
            // Write the log to a storage
            // ...
            //Dinamik olarak invoke ile çağırma yapıyoruz
            //Soru işareti neden geldi? if anlamı içermiyor gibi.
            ErrorLogged?.Invoke(this, Guid.NewGuid());
        }
    }
}