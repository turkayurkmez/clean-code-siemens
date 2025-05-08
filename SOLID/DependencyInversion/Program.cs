// See https://aka.ms/new-console-template for more information
using DependencyInversion;

/*
 *  Büyük nesneler kğçğk nesnelere bağlı olmamalı. Bunun yerine bağımlı olunan nesne, dışarıdan aktarılmalı.
 */

Console.WriteLine("Hello, World!");

MailSender sender = new MailSender();
WhatsAppSender whatsSender = new WhatsAppSender();
TelegramSender telegramSender = new TelegramSender();


ReportPublisher reportPublisher = new ReportPublisher(telegramSender);
//reportPublisher.Sender = sender;
reportPublisher.Send();



