namespace SendMailAndPassOperations.Services.Abstract
{
    public interface ISendMailService
    {
        public void SendMail(Dictionary<string,object> mailParams);

        public void ForgetPassword(string mail, string pass);

        public void ChangePassword(string mail, string newPass);

        public void NewPassword(long recId);

        public long CheckUser(string mail, string pass);
    }
}
