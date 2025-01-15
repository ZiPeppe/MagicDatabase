using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicDatabase.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoryeSubCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CardCategories",
                columns: new[] { "CardCategoryId", "CardCategoryName" },
                values: new object[,]
                {
                    { 4, "Terra" },
                    { 5, "Planeswalker" },
                    { 6, "Istantaneo" },
                    { 7, "Stregoneria" }
                });

            migrationBuilder.InsertData(
                table: "CardSubCategories",
                columns: new[] { "CardSubCategoryId", "CardCategoryID", "CardSubCategoryName" },
                values: new object[,]
                {
                    { 5, 3, "Cibo" },
                    { 6, 3, "Indizio" },
                    { 7, 3, "Tesoro" },
                    { 8, 3, "Sangue" },
                    { 9, 3, "Veicolo" },
                    { 10, 3, "Oro" },
                    { 11, 2, "Saga" },
                    { 12, 2, "Santuario" },
                    { 20, 1, "Consigliere" },
                    { 21, 1, "Alleato" },
                    { 22, 1, "Arciere" },
                    { 23, 1, "Scimpanzè" },
                    { 24, 1, "Antilope" },
                    { 25, 1, "Angelo" },
                    { 26, 1, "Arconte" },
                    { 27, 1, "Esercito" },
                    { 28, 1, "Artefice" },
                    { 29, 1, "Assassino" },
                    { 30, 1, "Addetto al Montaggio" },
                    { 31, 1, "Atog" },
                    { 32, 1, "Uri" },
                    { 33, 1, "Avatar" },
                    { 34, 1, "Azra" },
                    { 35, 1, "Tasso" },
                    { 36, 1, "Barbaro" },
                    { 37, 1, "Bardo" },
                    { 38, 1, "Basilisco" },
                    { 39, 1, "Pipistrello" },
                    { 40, 1, "Orso" },
                    { 41, 1, "Bestia" },
                    { 42, 1, "Bibolo" },
                    { 43, 1, "Berserker" },
                    { 44, 1, "Uccello" },
                    { 45, 1, "Lampidottero" },
                    { 46, 1, "Cinghiale" },
                    { 47, 1, "Portatore" },
                    { 48, 1, "Burlarbusto" },
                    { 49, 1, "Camarid" },
                    { 50, 1, "Cammello" },
                    { 51, 1, "Caribù" },
                    { 52, 1, "Felino" },
                    { 53, 1, "Centauro" },
                    { 54, 1, "Cefalide" },
                    { 55, 1, "Chimera" },
                    { 56, 1, "Cittadino" },
                    { 57, 1, "Chierico" },
                    { 58, 1, "Coccatrice" },
                    { 59, 1, "Costrutto" },
                    { 60, 1, "Vigliacco" },
                    { 61, 1, "Granchio" },
                    { 62, 1, "Coccodrillo" },
                    { 63, 1, "Ciclope" },
                    { 64, 1, "Dauthi" },
                    { 65, 1, "Semidio" },
                    { 66, 1, "Demone" },
                    { 67, 1, "Disertore" },
                    { 68, 1, "Diavolo" },
                    { 69, 1, "Dinosauro" },
                    { 70, 1, "Genio" },
                    { 71, 1, "Canide" },
                    { 72, 1, "Drago" },
                    { 73, 1, "Draghetto" },
                    { 74, 1, "Sterminatore" },
                    { 75, 1, "Drone" },
                    { 76, 1, "Druido" },
                    { 77, 1, "Driade" },
                    { 78, 1, "Nano" },
                    { 79, 1, "Efreet" },
                    { 80, 1, "Uovo" },
                    { 81, 1, "Antico" },
                    { 82, 1, "Eldrazi" },
                    { 83, 1, "Elementale" },
                    { 84, 1, "Elefante" },
                    { 85, 1, "Alce" },
                    { 86, 1, "Occhio" },
                    { 87, 1, "Spiritello" },
                    { 88, 1, "Furetto" },
                    { 89, 1, "Pesce" },
                    { 90, 1, "Portabandiera" },
                    { 91, 1, "Volpe" },
                    { 92, 1, "Frattale" },
                    { 93, 1, "Rana" },
                    { 94, 1, "Fungus" },
                    { 95, 1, "Gargoyle" },
                    { 96, 1, "Microbo" },
                    { 97, 1, "Gigante" },
                    { 98, 1, "Gnomo" },
                    { 99, 1, "Capra" },
                    { 100, 1, "Dio" },
                    { 101, 1, "Goblin" },
                    { 102, 1, "Golem" },
                    { 103, 1, "Gorgone" },
                    { 104, 1, "Figlio della Tomba" },
                    { 105, 1, "Gremlin" },
                    { 106, 1, "Grifone" },
                    { 107, 1, "Strega" },
                    { 108, 1, "Criceto" },
                    { 109, 1, "Arpia" },
                    { 110, 1, "Infernale" },
                    { 111, 1, "Ippopotamo" },
                    { 112, 1, "Ippogrifo" },
                    { 113, 1, "Homarid" },
                    { 114, 1, "Omuncolo" },
                    { 115, 1, "Orrore" },
                    { 116, 1, "Cavallo" },
                    { 117, 1, "Umano" },
                    { 118, 1, "Idra" },
                    { 119, 1, "Iena" },
                    { 120, 1, "Illusione" },
                    { 121, 1, "Imp" },
                    { 122, 1, "Incarnazione" },
                    { 123, 1, "Scarabocchio" },
                    { 124, 1, "Insetto" },
                    { 125, 1, "Sciacallo" },
                    { 126, 1, "Medusa" },
                    { 127, 1, "Juggernaut" },
                    { 128, 1, "Kavu" },
                    { 129, 1, "Kirin" },
                    { 130, 1, "Kithkin" },
                    { 131, 1, "Cavaliere" },
                    { 132, 1, "Coboldo" },
                    { 133, 1, "Kor" },
                    { 134, 1, "Kraken" },
                    { 135, 1, "Lamia" },
                    { 136, 1, "Lammasu" },
                    { 137, 1, "Sanguisuga" },
                    { 138, 1, "Leviatano" },
                    { 139, 1, "Lhurgoyf" },
                    { 140, 1, "Licide" },
                    { 141, 1, "Lucertola" },
                    { 142, 1, "Manticora" },
                    { 143, 1, "Masticora" },
                    { 144, 1, "Mercenario" },
                    { 145, 1, "Tritone" },
                    { 146, 1, "Metathran" },
                    { 147, 1, "Servitore" },
                    { 148, 1, "Minotauro" },
                    { 149, 1, "Talpa" },
                    { 150, 1, "Commerciante" },
                    { 151, 1, "Mangusta" },
                    { 152, 1, "Monaco" },
                    { 153, 1, "Scimmia" },
                    { 154, 1, "Lunantropo" },
                    { 155, 1, "Mutante" },
                    { 156, 1, "Myr" },
                    { 157, 1, "Mistico" },
                    { 158, 1, "Naga" },
                    { 159, 1, "Nautilo" },
                    { 160, 1, "Nephilim" },
                    { 161, 1, "Incubo" },
                    { 162, 1, "Topo" },
                    { 163, 1, "Cacciatore Notturno" },
                    { 164, 1, "Ninja" },
                    { 165, 1, "Nobile" },
                    { 166, 1, "Noggle" },
                    { 167, 1, "Nomade" },
                    { 168, 1, "Ninfa" },
                    { 169, 1, "Piovra" },
                    { 170, 1, "Ogre" },
                    { 171, 1, "Melma" },
                    { 172, 1, "Globo" },
                    { 173, 1, "Orco" },
                    { 174, 1, "Lontra" },
                    { 175, 1, "Servomeccanismo" },
                    { 176, 1, "Scheggia" },
                    { 177, 1, "Tentacolo" },
                    { 178, 1, "Troll" },
                    { 179, 1, "Tartaruga" },
                    { 180, 1, "Unicorno" },
                    { 181, 1, "Vampiro" },
                    { 182, 1, "Vedalken" },
                    { 183, 1, "Viashino" },
                    { 184, 1, "Muro" },
                    { 185, 1, "Guerriero" },
                    { 186, 1, "Mannaro" },
                    { 187, 1, "Balena" },
                    { 188, 1, "Mago" },
                    { 189, 1, "Lupo" },
                    { 190, 1, "Zubera" },
                    { 13, 4, "Cancello" },
                    { 14, 4, "Deserto" },
                    { 15, 4, "Pianura" },
                    { 16, 4, "Isola" },
                    { 17, 4, "Foresta" },
                    { 18, 4, "Palude" },
                    { 19, 4, "Montagna" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardCategories",
                keyColumn: "CardCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CardCategories",
                keyColumn: "CardCategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CardCategories",
                keyColumn: "CardCategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "CardSubCategories",
                keyColumn: "CardSubCategoryId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "CardCategories",
                keyColumn: "CardCategoryId",
                keyValue: 4);
        }
    }
}
