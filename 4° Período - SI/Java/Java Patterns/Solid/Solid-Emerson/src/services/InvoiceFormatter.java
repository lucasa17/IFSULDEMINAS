package services;

import model.Invoice;
import model.Item;

public class InvoiceFormatter {

    public String format(Invoice invoice) {
        StringBuilder formattedInvoice = new StringBuilder("Invoice for " + invoice.getCustomer() + "\n");
        
        for (Item item : invoice.getItems()) {
            formattedInvoice.append(item.getName())
                            .append(": ")
                            .append(item.getQuantity())
                            .append(" x ")
                            .append(item.getPrice())
                            .append(" = ")
                            .append(item.getQuantity() * item.getPrice())
                            .append("\n");
        }
        
        formattedInvoice.append("Total: ").append(invoice.calculateTotal());
        
        return formattedInvoice.toString();
    }
}