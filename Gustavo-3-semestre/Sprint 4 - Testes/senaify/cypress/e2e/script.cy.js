describe("template spec", () => {
  let musicItem;

  it("passes", () => {
    cy.visit("/");
  });

  it("Visualizar playlists e executar uma música", () => {
    cy.get("[aria-label='title-head']");
    //eu vejo o header "Good morning"
    cy.get("[aria-label='title-head']").should("contain", "Good morning");
    //eu vejo uma lista de playlists
    cy.get("[aria-label='playlist-item']").should("have.length.greaterThan", 0);
    //eu clico na primeira playlist
    //eu vejo uma lista de músicas
    cy.get("[aria-label='playlist-item']").first().click();
    //eu clico na primeira música
    //a música começa a tocar
    cy.get("[aria-label='music-item']").first().click();
  });

  it("Navegar entre playlists e executar outra música", () => {
    cy.wait(2000);
    //eu volto para a listagem de playlists
    cy.get("[data-testid='backButton-item']").click();
    //eu clico na segunda playlist
    //eu vejo uma lista de músicas
    cy.get("[aria-label='playlist-item']").eq(1).click();
    //eu clico na primeira música
    //a música começa a tocar
    cy.get("[aria-label='music-item']").first().click();
  });

  it("Procurar e favoritar uma música", () => {
    cy.wait(2000);
    //que eu estou na tela de Pesquisa
    cy.get("[href='/Search']").click();
    //eu procuro por uma música "Nome da Música"
    //eu vejo uma lista de resultados de músicas
    cy.get("[data-testid='campoBusca']").type("Meninos do Torro");
    //eu clico na primeira música dos resultados
    //a música começa a tocar
    musicItem = cy.get("[aria-label='music-item']");
    cy.wait(2000).contains("Mc Kelvinho").click();
    //eu clico para favoritar a música
    //a música é adicionada à lista de favoritos
    cy.get(musicItem).get("[data-testid='icon-button-sch']").first().click();
    musicItem = cy.get("[aria-label='music-item']");
    cy.wait(2000).contains("Mc Kelvinho").click();
  });

  it("Verificar música favoritada na tela de Favoritos", () => {
    //que eu estou na tela de Favoritos
    //eu vejo uma lista de músicas favoritas
    //eu vejo a música favoritada na lista
    cy.get("[href='/Favorites']").click();
    cy.scrollTo("top");
    //eu clico na música favoritada
    //a música começa a tocar

    //A FAZER --------------------------------------------------------
    //TOCAR A MUSICA QUE FAVORITEI
  });
});
