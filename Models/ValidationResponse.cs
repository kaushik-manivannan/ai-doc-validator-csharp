using Newtonsoft.Json;

namespace DocumentValidator.Models
{
    public class ValidationResponse
    {
        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; } = string.Empty;

        [JsonProperty("fein")]
        public string Fein { get; set; } = string.Empty;

        [JsonProperty("results")]
        public List<ValidationResult> Results { get; set; } = new List<ValidationResult>();

        [JsonProperty("skippedDocuments")]
        public List<SkippedDocument> SkippedDocuments { get; set; } = new List<SkippedDocument>();

        [JsonProperty("consolidatedReportBase64")]
        public string ConsolidatedReportBase64 { get; set; } = string.Empty;
    }

    public class ValidationResult
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; } = string.Empty;

        [JsonProperty("documentType")]
        public string DocumentType { get; set; } = string.Empty;

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("missingElements")]
        public List<string> MissingElements { get; set; } = new List<string>();

        [JsonProperty("suggestedActions")]
        public List<string> SuggestedActions { get; set; } = new List<string>();

        [JsonProperty("documentInfo")]
        public DocumentInfo DocumentInfo { get; set; } = new DocumentInfo();

        [JsonProperty("error")]
        public string? Error { get; set; }
    }

    public class DocumentInfo
    {
        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("wordCount")]
        public int WordCount { get; set; }

        [JsonProperty("languageInfo")]
        public List<LanguageInfo> LanguageInfo { get; set; } = new List<LanguageInfo>();

        [JsonProperty("containsHandwriting")]
        public bool ContainsHandwriting { get; set; }

        [JsonProperty("documentType")]
        public string DocumentType { get; set; } = string.Empty;

        [JsonProperty("detectedOrganizationName")]
        public string? DetectedOrganizationName { get; set; }

        [JsonProperty("originalDocumentType")]
        public string? OriginalDocumentType { get; set; }

        [JsonProperty("typeDetection")]
        public TypeDetection TypeDetection { get; set; } = new TypeDetection();
    }

    public class LanguageInfo
    {
        [JsonProperty("languageCode")]
        public string LanguageCode { get; set; } = string.Empty;

        [JsonProperty("confidence")]
        public float Confidence { get; set; }
    }

    public class TypeDetection
    {
        [JsonProperty("topScores")]
        public List<DocumentTypeScore> TopScores { get; set; } = new List<DocumentTypeScore>();

        [JsonProperty("detectionConfidence")]
        public string DetectionConfidence { get; set; } = "0";
    }

    public class DocumentTypeScore
    {
        [JsonProperty("type")]
        public string Type { get; set; } = string.Empty;

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("threshold")]
        public int Threshold { get; set; }
    }

    public class SkippedDocument
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; } = string.Empty;

        [JsonProperty("reason")]
        public string Reason { get; set; } = string.Empty;

        [JsonProperty("typeDetection")]
        public TypeDetection TypeDetection { get; set; } = new TypeDetection();
    }
} 