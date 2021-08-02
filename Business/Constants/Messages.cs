using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz"; 
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string MaksimumProduct = "Bir kategoride maksimum 10 adet ürün olabilir.";
        public static string ProductNameAlreadyExist = "Ürün adı zaten var";
        public static string CategorryLimitExceded = "Ürün ler için maksimum kategori sayısı geçildi.";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut";
        public static string UserRegistered = "Kullanıcı kaydedildi";
        public static string SuccessfulLogin = "Başarılı  giriş";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Hatalı şifre";
        public static string UserAlreadyExists = "Kullanıcı zaten kullanımda";
        public static string AccessTokenCreated = "Access Token oluşturuldu";
        
        
    }
}
