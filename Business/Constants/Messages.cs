using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün adı geçersiz";
        public static string MaintenanceTime = "Sunucu bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Kategorideki ürün adedini aştınız!";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategegoryLimitExceded = "Kategory Limiti aşıldığı için Yeni ürün eklenemiyor";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserNotFound = "Kullanıcı Bulunamadı";

        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated { get; internal set; }
        public static string UserRegistered = "Kayıt oldu";
    }
}
