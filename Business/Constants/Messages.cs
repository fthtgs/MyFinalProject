using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages    // new'lenmemesi için static yaptık
    {
        public static string ProductAdded = "Ürün eklendi!";
        public static string ProductNameInvalid = "Ürün ismi en az iki karakterli olmalıdır!";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string MaintenanceTime = "Bakım zamanıdır. Lütfen daha sonra tekrar deneyiniz!";
        public static string ProductCountOfCategoryError = "Kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var!";
        public static string CategoryLimitExceded = "Categori limiti aşıldığı için yeni ürün eklenemiyor.";
    }
}
