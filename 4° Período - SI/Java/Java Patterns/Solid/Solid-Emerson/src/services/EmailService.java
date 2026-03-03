package services;

public class EmailService {

    public void sendInvoiceEmail(String email, String formattedInvoice) {
        System.out.println("Sending invoice to " + email + ":\n" + formattedInvoice);
    }
}