namespace PersonalBlazorPage.Services
{
    public class TransitionState
    {
        public string professionalTransition = "";
        public string professionalSectionTransition = "prof-section-before";
        public string personalTransition = "";

        public void SetProfessionalUp()
        {
            professionalTransition = "blast-off";
            professionalSectionTransition = "prof-section-after";
        }

        public void SetProfessionalDown()
        {
            professionalTransition = "";
            professionalSectionTransition = "prof-section-before";
        }
    }
}
