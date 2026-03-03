package view;

import model.Invoice;
import model.Item;
import services.EmailService;
import services.InvoiceFormatter;

public class Main {
    public static void main(String[] args) {
        EmailService emailService = new EmailService();
        InvoiceFormatter formatter = new InvoiceFormatter();
        Invoice invoice = new Invoice("Emerson Carvalho");
        invoice.addItem(new Item("Produto A", 2, 50));
        invoice.addItem(new Item("Produto B", 3, 30));
        
        String formattedInvoice = formatter.format(invoice);
        
        emailService.sendInvoiceEmail("emerson@email.com", formattedInvoice);
    }
}
