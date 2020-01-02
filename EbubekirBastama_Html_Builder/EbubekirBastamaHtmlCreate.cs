
namespace EbubekirBastama_Html_Builder
{
    public class EbubekirBastamaHtmlCreate
    {
        //*İletişim ve Eğitim Adreslerimiz..*//

        //Contact : +90 5554128854;
        //Whatshapp Contact : +90 5554128854;
        //Email Contact : ebubekirbastama@elmalicesmekuruyemis.com
        //Website Contact : https://www.ebubekirbastama.com
        //Education https://www.youtube.com/user/yazilimegitim
        //Education https://www.youtube.com/channel/UC240A7DHqgAR8bEMakGdqWg/videos?view_as=subscriber

        #region Değişkenler

        private static string altsatir { get; set; } = "\n";
        private static string dc { get; set; }
        private static string html1 { get; set; }
        private static string html2 { get; set; }
        private static string htmlici { get; set; }
        private static string head1 { get; set; }
        private static string head2 { get; set; }
        private static string title1 { get; set; }
        private static string title2 { get; set; }
        private static string headici { get; set; }
        private static string titleici { get; set; }
        private static string bodyici { get; set; }
        private static string body1 { get; set; }
        private static string body2 { get; set; }
        private static string cıktıhtml { get; set; }

        #endregion
        #region Metodlar
        public static string Dc()
        {
            dc = "<!DOCTYPE html>";
            return dc;
        }
        public static string Htmlici(string dil, string headici, string bodyici)
        {
            htmlici = Html1(dil) +

                altsatir +

                Headici(headici) +

                altsatir +

                Bodyici(bodyici) +

                altsatir +

                Html2();

            return htmlici;
        }
        public static string Html1(string dil)
        {
            html1 = "<html lang=\"" + dil + "\">";
            return html1;
        }
        public static string Html2()
        {
            html2 = "</html>";
            return html2;
        }
        public static string Head1()
        {
            head1 = "<head>";
            return head1;
        }
        public static string Head2()
        {
            head2 = "</head>";
            return head2;
        }
        public static string Body1()
        {
            body1 = "<body>";
            return body1;
        }
        public static string Body2()
        {
            body2 = "</body>";
            return body2;
        }
        public static string Title1()
        {
            title1 = "<title>";
            return title1;
        }
        public static string Title2()
        {
            title2 = "</title>";
            return title2;
        }
        public static string Headici(string heeaadici)
        {
            headici = Head1() + altsatir + heeaadici + altsatir + Head2();
            return headici;
        }
        public static string Titleici(string titleeici)
        {
            titleici = Title1() + titleeici + Title2();
            return titleici;
        }
        public static string Bodyici(string bodyicii)
        {
            bodyicii = Body1() + altsatir + bodyicii + altsatir + Body2();
            return bodyicii;
        }
        #endregion
        #region çıktımetodu
        public static string CıktıHtml(string dil, string headici, string bodyici)
        {
            cıktıhtml = Htmlici(dil, headici, bodyici);
            return cıktıhtml;
        }
        #endregion
    }
}
