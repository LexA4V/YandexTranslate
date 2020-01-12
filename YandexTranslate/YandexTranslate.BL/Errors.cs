using System.Collections.Generic;

namespace YandexTranslate.BL
{
    class ErrorJSON
    {
        private static Dictionary<int, string> _errors = new Dictionary<int, string>()
        {
            [200] = "Операция выполнена успешно",
            [401] = "Неправильный API-ключ",
            [402] = "API-ключ заблокирован",
            [404] = "Превышено суточное ограничение на объем переведенного текста",
            [413] = "Превышен максимально допустимый размер текста",
            [422] = "Текст не может быть переведен",
            [501] = "Заданное направление перевода не поддерживается"
        };

        public static string WhatIs(int errorCode)
        {
            bool res = _errors.TryGetValue(errorCode, out string message);
            return res ? message : string.Empty;
        }
    }
}