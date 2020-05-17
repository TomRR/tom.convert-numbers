# tom.convert-numbers
Konsolen-Programm, welches indische Zahlen in römische Zahlen umrechnet und umgekehrt

Schreiben Sie ein fehlerfrei reagierendes, sinnvoll strukturiertes Konsolen-Programm welches indische Zahlen in römische Zahlen mit enums umrechnet (I=1, V=5, X=10, L=50, C=100, D=500 und M=1000) und wieder zurück.

Zur besseren Verwaltung verwenden Sie bitte einen eigenen Namespace mit ihrem Namen und zur Ansprechbarkeit des Programms soll das Interface eingebunden werden, siehe Anhang.

Beispiel: MLIX = 1059
Bewertungsmatrix

* [ X ] 10% Allgemeine Benutzbarkeit
* [ X ] 05% Arbeit mit Namespaces
* [ X ] 45% indisch-arabische > römische Zahlen
* [ X ] 10% Einhaltung von Styleguies
* [ X ] 15% Einbindung des Interfaces
* [ X ] 20% römische > indisch-arabische Zahlen
* [ X ] 15% Klassendiagramm (OOA oder OOD)

Tipps zum Lösen

    Überlegen Sie, wie sie manuell die Zahl umwandeln.
    Legen Sie das Enum an und berücksichtigen Sie auch die Spezialfälle. Es könnte einfacher sein, wenn Sie im Enum auch IX->9 einbauen.
    Es empfiehlt sich, die Eingabe zeichenweise zu verarbeiten und das Ergebnis zusammenbauen.

## UML Diagramm
<img src="https://ecstatic-edison-c0b108.netlify.app/school/convertingnumbers/images/UML%20Diagramm.PNG"
     alt="UML Darstellung Converting Numbers"/>