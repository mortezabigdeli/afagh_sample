using System.Collections.Generic;


namespace my_projects.Models
{
	public class ProfileVewModel
	{
		public List<ProfileSectionViewModel> Specs { get; set; }
		public List<ProfileSectionViewModel> Office { get; set; }
		public List<ProfileSectionViewModel> Address { get; set; }
		public List<LinkIconInfoViewModel> Info { get; set; }
	}
}