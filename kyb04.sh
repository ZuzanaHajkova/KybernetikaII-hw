#zalozeni novych slozek
mkdir -p hw04/Zapis
mkdir -p hw04/Archiv

#vytvoreni souboru
soubor="hw04/Zapis/datum_cas.txt"

#vypsani datumu a casu do souboru
echo "Datum a cas : $(date)" > "$soubor"


#zaloha slozky
zip -r "hw04/Archiv/backup.zip" hw04/Zapis > /dev/null

echo "hotovo"
