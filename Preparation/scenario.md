1) Obecný scénář Vaší aplikace.

Vstupem aplikace je tabulka počtu zapsaných studentů. 
Tajemník si ji manuálně překliká do aplikace.
Předměty a ročníky studia budou propojené.
V aplikaci tajemník uvidí kartičky cvičení, seminářů nebo přednášek, je potřeba aby tam byli místa pro všechny studenty. 
Automaticky se ty cvika (semináře nebo přednášky) vygenerují pro všechny studenty.

Úvazek 
	- interval <0;1>
	- např. poloviční je 0,5

Aplikace
	- slouží pro navržení úvazkových listů pro jednotlivé zaměstnance
	- musí perzistentně ukládat data dvěma způsoby: pomocí SQL databáze a XML souborů
	- generuje štítky na základě počtu studentů ve studijním oboru
	- udržuje seznam předmětů za které je ústav odpovědný
	- podle dodaného počtu studentů (z tabulky) se předmětům vygenerují kartičky(štítky)
	- kartičky se přiřadí zaměstnancům ústavu, kartičky se musí dát "přešoupávat" mezi zaměstnanci
	- musí být vidět kolik bodů úvazku má který zaměstnanec, nesmí překročit 500 bodů úvazku

Štítek
	- je přednáška, cvičení nebo seminář
	- má definovaný max. počet studentů
	- má definovaný způsob zakončení studia
	- má definovaný počet úvazkových bodů
	- může být přiřazen konkrétnímu zaměstnanci, po přiřazení se započítá do jeho úvazkových bodů
	- zaměstnanec přiřazený ke štítku může být změněn
	- může být smazán

Tajemník
	- může přidat (i smazat) ZAMĚSTNANCE pomocí formuláře
		-> zvolí výši úvazku (buď nemá úvazek nebo je na dohodu nebo musí naplňovat výši úvazku (těch 500 bodů))
		-> má jméno, email a tel. číslo
		-> může být zařazen k žádnému nebo více štítkům

	- může přidat (i smazat) nový OBOR studia pomocí formuláře

	- může přidat (i smazat) PŘEDMĚT pomocí formuláře 
		-> definuje zkratku, název, rozsah (přednášky, semináře nebo cvika), způsob zakončení, obor kterého se týká a ústav do kterého patří
		-> nastaví počet osob na cviku
	
---------------------------------------------------
2) Otázky na které se chcete zeptat.



---------------------------------------------------
3) Technologie, které chcete použít.

Frontend -> Windows Forms
Backend -> C#, SQL