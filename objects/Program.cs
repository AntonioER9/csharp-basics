// // Sale sale = new Sale (); //Crear un objeto
// // Sale sale = new(); //Crear un objeto
// var sale = new Sale(15); //Crear un objeto; var no tiene nada que ver con el de javascript
// var sale2 = new SaleWithTax(15, 1.16m);
// var message = sale.GetInfo();

// Console.WriteLine(message);

// class SaleWithTax : Sale
// {
//   public decimal Tax { get; set; }
//   public SaleWithTax(decimal total, decimal tax) : base(total)
//   {
//     // GetInfo();
//     Tax = tax;
//   }
//   public string GetInfoWithTax()
//   {
//     return "El total es " + Total + " Impuesto es: " + Tax;
//   }
// }


// class Sale
// {
//   public decimal Total { get; set; } //obtener y modificar
//   private decimal _some; //solo se puede acceder desde la misma clase.
//   protected decimal _other; //pueden acceder hijos que hereden de esta clase
  
//   public Sale(decimal total) //Constructor
//   {
//     Total = total; //this hace alusión al total de arriba al del la clase (9)
//     _some = 8;
//   }

//   public string GetInfo()
//   {
//     return "El total es " + Total;
//   }
// }