using System.ComponentModel.DataAnnotations;

namespace LinkBakery.Web.Cms.Dtos
{
    public class TrackingLinkEditDto
    {
        public int Id { get; set; }
        public string Key { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "Die Ziel Url muss zwischen 5 und 500 Zeichen enthalten!")]
        public string TargetUrl { get; set; }
        public bool IsActive { get; set; }
        public bool RedirectWithQueryParameter { get; set; }
    }
}
