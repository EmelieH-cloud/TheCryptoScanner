using Newtonsoft.Json;
namespace MyCryptoScanner.Data.Models
{

    // https://api.coingecko.com/api/v3/coins/{NameofCoin}
    public class CoinInfoRoot
    {

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }


    // https://api.coingecko.com/api/v3/simple/price?ids=01coin%2C0chain%2C0-knowledge-network%2C0-mee%2C0vix-protocol%2C0vm%2C0x%2C0x0-ai-ai-smart-contract%2C0x1-tools-ai-multi-tool%2C0xaiswap%2C0xanon%2C0xblack%2C0xcoco%2C0xconnect&vs_currencies=sek
    public class PriceRoot
    {
        [JsonProperty("01coin")]
        public _01coin? _01coin { get; set; }

        [JsonProperty("0chain")]
        public _0chain? _0chain { get; set; }

        [JsonProperty("0-knowledge-network")]
        public _0KnowledgeNetwork? _0knowledgenetwork { get; set; }

        [JsonProperty("0-mee")]
        public _0Mee? _0mee { get; set; }


        [JsonProperty("0x")]
        public _0x? _0x { get; set; }

        [JsonProperty("0x0-ai-ai-smart-contract")]
        public _0x0AiAiSmartContract? _0x0aiaismartcontract { get; set; }

        [JsonProperty("0x1-tools-ai-multi-tool")]
        public _0x1ToolsAiMultiTool? _0x1toolsaimultitool { get; set; }

        [JsonProperty("0xaiswap")]
        public _0xaiswap? _0xaiswap { get; set; }

        [JsonProperty("0xanon")]
        public _0xanon? _0xanon { get; set; }

        [JsonProperty("0xblack")]
        public _0xblack? _0xblack { get; set; }

        [JsonProperty("0xcoco")]
        public _0xcoco? _0xcoco { get; set; }

        [JsonProperty("0xconnect")]
        public _0xconnect? _0xconnect { get; set; }
    }
    public class _01coin
    {
        [JsonProperty("sek")]
        public double Sek { get; set; }
    }

    public class _0chain
    {
        [JsonProperty("sek")]
        public double Sek { get; set; }
    }

    public class _0KnowledgeNetwork
    {
        [JsonProperty("sek")]
        public double Sek { get; set; }
    }

    public class _0Mee
    {
        [JsonProperty("sek")]
        public double Sek { get; set; }
    }


    public class _0x
    {
        [JsonProperty("sek")]
        public double Sek { get; set; }
    }

    public class _0x0AiAiSmartContract
    {
        [JsonProperty("sek")]
        public double Sek { get; set; }
    }

    public class _0x1ToolsAiMultiTool
    {
        [JsonProperty("sek")]
        public double Sek { get; set; }
    }

    public class _0xaiswap
    {
        [JsonProperty("sek")]
        public double Sek { get; set; }
    }

    public class _0xanon
    {
        [JsonProperty("sek")]
        public double Sek { get; set; }
    }

    public class _0xblack
    {
        [JsonProperty("sek")]
        public double Sek { get; set; }
    }

    public class _0xcoco
    {
        [JsonProperty("sek")]
        public double Sek { get; set; }
    }

    public class _0xconnect
    {
        [JsonProperty("sek")]
        public double Sek { get; set; }
    }




}