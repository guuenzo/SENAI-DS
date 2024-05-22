describe("template spec", () => {
  let musicItem;

  before(() => {
    cy.visit("/");
  });

  it("redirecionar para a tela de busca", () => {
    cy.get("[href='/Search']").click();
    cy.scrollTo("top");
  });

  it("procurando uma musica especifica", () => {
    cy.get("[data-testid='campoBusca']").type("A semente");

    cy.get("[aria-label='music-item']").should("have.length.greaterThan", 0);
  });

  it("clicar na musica desejada", () => {
    musicItem = cy
      .get("[aria-label='music-item']")
      .contains("Bezerra Da Silva");

    musicItem.click();
  });

  it("clicar no curtir da musica", () => {
    cy.get(musicItem).get("[data-testid='icon-button']").first().click();
  });
});
