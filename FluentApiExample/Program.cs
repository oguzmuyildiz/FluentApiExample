// See https://aka.ms/new-console-template for more information
using FluentApiExample;

var senderResult = FluentEmailSender.CreateSender(config =>
{
    config.ApiKey = "something key here";
})
.SetServer("xxx")
.SetSubject("Subject")
.SetBody("Message body")
.AddTo("toexample@example.com")
.Send();
