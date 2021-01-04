# PDF. IT

![GUI2](https://github.com/kamilmix/PDF.it/blob/master/PDF.it/Images/gui2.JPG "GUI2")
![GUI](https://github.com/kamilmix/PDF.it/blob/master/PDF.it/Images/gui.JPG "GUI")

Aplikacja umożliwiająca łączenie/dzielenie plików PDF, działająca lokalnie bez wysyłania plików na serwer w celu ochrony prywatnych danych.

---

#### Założenia:
- łączenie wielu plików PDF w jeden;
- dzielenie pliku PDF zawierającego wiele stron na pojedyncze strony do osobnych plików;
- prosty interfejs obsługujący przeciągnij i upuść (ang. drag and drop).

Aplikacja została napisana na zaliczenie przedmiotu Aplikacje użytkowe, przy użyciu języka C# oraz Windows Forms. Przy projektowaniu starałem się zachować ładny wygląd aplikacji oraz stosować zasady czystego kodu.

Interfejs programu składa się z dwóch głównych zakładek, wybieranych z menu po lewej stronie. 
1. **Podziel PDF** – w tej zakładce mamy możliwość podzielenia pliku PDF na pojedyncze strony. Możemy wskazać plik ręcznie lub poprzez przeciągnięcie i upuszczenie go na oknie programu.
2. **Połącz PDF** – zakładka, na której możemy połączyć wiele plików PDF w jeden. Pliki możemy dodawać ręcznie, lub poprzez przeciągnięcie i upuszczenie na białym polu.

Domyślnie katalogiem docelowym, w którym zapisują się nasze pliki jest folder Dokumenty. Na każdej zakładce możemy wskazać inny katalog. Po przetworzeniu katalog docelowy zostaje otwarty w eksploratorze plików.


---

##### W programie zostały użyte zewnętrzne biblioteki:
- [iText7](https://itextpdf.com/), która umożliwia tworzenie i manipulowanie dokumentów w formacie PDF.
- [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin/), która dostarcza motyw zgodny z zasadami projektowania Material Design.


