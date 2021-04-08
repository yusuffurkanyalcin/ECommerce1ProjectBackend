using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string NotFoundUser = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string UserRegistered = "Kullanıcı oluşturuldu";

        public static string ProductAdded = "Ürün eklendi";
        public static string ProductDeleted = "Ürün silindi";
        public static string NotFoundProduct = "Ürün bulunamadı";
    }
}
