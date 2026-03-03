package view;

import java.time.LocalDate;

import model.Sale;
import model.SaleItem;
import model.SalePresenter;

public class ConsoleSalePresenter implements SalePresenter {

	@Override
	public void show(Sale sale) {
		System.out.println("Nota de Venda - " + LocalDate.now());
		System.out.printf("%-15s %-10s %-10s %-10s","Produto", "Preço","Quantidade", "Total");
		
		System.out.println();
		
		for (SaleItem item : sale.getItems()) {
			System.out.printf("%-15s %-10.2f %-10d %-10.2f\n",item.getProduct().getDescription(),
			item.getProduct().getPrice(),
			item.getAmount(),
			item.getTotalAmount());
		}
		
		System.out.printf("%37s %.2f ", "Total" ,sale.getTotalAmount());
	}

}
