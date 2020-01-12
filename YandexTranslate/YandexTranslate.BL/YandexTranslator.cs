using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace YandexTranslate.BL
{
    class YandexTranslator
    {
        private readonly string key;
        private readonly string uri;

        protected YandexTranslator()
        {
            uri = "https://translate.yandex.net/api/v1.5/tr.json/";
        }

        public YandexTranslator(string key) : this()
        {
            this.key = key;
        }

        /// <summary>
        /// Запрос перевода текста с одного языка на другой
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <param name="lang">Направление перевода. Пример: "ru-en", "ru-pl", "ru-hu"</param>
        /// <returns>Переведённый текст</returns>
        public string Translate(string text, string lang)
        {
            var result = Get<TranslationJSON>($"{uri}translate?key={key}&text={text}&lang={lang}");

            return string.Concat(result.text);
        }

        /// <summary>
        /// Получает список поддерживаемых языков для перевода
        /// </summary>
        /// <param name="ui">В ответе список поддерживаемых языков будет перечислен в поле langs вместе с расшифровкой кодов языков. Названия языков будут выведены на языке, код которого соответствует этому параметру.</param>
        /// <returns>Словарь: "Код языка"-"Наменование"</returns>
        public Dictionary<string, string> GetLangs(string ui = "en")
        {
            var result = Get<LangsJSON>($"{uri}getLangs?ui={ui}&key={key}");

            return result.langs;
        }

        private T Get<T>(string uri)
        {
            WebRequest request = WebRequest.Create(uri);

            var resp = request.GetResponse();

            var stream = new StreamReader(resp.GetResponseStream());
            var text = stream.ReadToEnd();
            stream.Close();

            return JsonConvert.DeserializeObject<T>(text);
        }
    }
}
