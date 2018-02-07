namespace HereAreTheClothesYouWant.Services
{
    public interface IMailService
    {
        void sendMessage(string to, string subject, string address);
    }
}