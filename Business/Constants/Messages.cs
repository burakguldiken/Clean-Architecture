using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Başarıyla Eklendi";
        public static string ProductDeleted = "Ürün Başarıyla Silindi";
        public static string ProductUpdated = "Ürün Başarıyla Güncellendi";

        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Hatalı Şifre";
        public static string UserAlreadyExists = "Böyle Bir Kullanıcı Zaten Var";
        public static string UserRegistered = "Kullanıcı Kaydedildi";
        public static string AccessTokenCreated = "Access Token Başarıyla Oluşturuldu";
    }
}
