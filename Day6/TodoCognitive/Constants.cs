namespace TodoCognitive
{
    public static class Constants
    {
        public static readonly string SpeechAuthenticationTokenEndpoint = "https://eastus2.api.cognitive.microsoft.com/sts/v1.0";
        public static readonly string AuthenticationTokenEndpoint = "https://api.cognitive.microsoft.com/sts/v1.0";

        public static readonly string BingSpeechApiKey = "49ae84c3086840639753f6ad122d2ab7";
        public static readonly string SpeechRecognitionEndpoint = "https://eastus2.stt.speech.microsoft.com/speech/recognition/";
        public static readonly string AudioContentType = @"audio/wav; codec=""audio/pcm""; samplerate=16000";

        public static readonly string BingSpellCheckApiKey = "1f7c56f979224dc4a9db5152d3445af2";
        public static readonly string BingSpellCheckEndpoint = "https://api.cognitive.microsoft.com/bing/v7.0/SpellCheck";

        public static readonly string TextTranslatorApiKey = "de13b1d7f3b347f2bdcd119572ab5701";
        public static readonly string TextTranslatorEndpoint = "https://api.microsofttranslator.com/v2/http.svc/translate";

        public static readonly string FaceApiKey = "1cf4b3b859c246f3b62f4b834f6c6bd6";
        public static readonly string FaceEndpoint = "https://eastus2.api.cognitive.microsoft.com/face/v1.0";

        public static readonly string AudioFilename = "Todo.wav";
    }
}
