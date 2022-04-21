#include <stdio.h>

int main()
{
	
	float apt,diaria, promocao, valorTotal, valor70, valorperdido;
	
	printf("Mini projeto de calculadora de sistema para hoteis considerando promocao de 25 %% na diaria \n \n");
	
	printf("Desenvolvedor: Walker A. Souza. \n \n");
	
	printf("Desenvolvido em 21/04/2022 \n \n");
	
	printf("Insira o valor da diaria \n");
	scanf("%f", &diaria);
	
	printf("Insira a quantidade total de apartamentos \n");
	scanf("%f", &apt);
	
	promocao = diaria - (diaria*0.25);
	
	valorTotal = promocao * apt;
	
	valor70 = promocao *(apt*0.7);
	
	valorperdido = (diaria*apt)-valorTotal;
	
	printf("O valor da promocao e de: %.2f \n \n", promocao);
	
	printf("O valor adquirido com 100 %% das diarias com promocao e de: %.2f \n \n", valorTotal);
	
	printf("O valor adquirido com 70 %% de ocupacao e de: %.2f \n \n", valor70);
	
	printf("Simulador do valor perdido na diferenca entre diaria completa e promocao e de: %.2f \n \n \n", valorperdido);

	printf("Contato do desenvolvedor: souzawalker18@gmail.com \n \n \n");
	
	system("PAUSE");
	
	
	return(0);
}
