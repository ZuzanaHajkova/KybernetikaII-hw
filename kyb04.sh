#zalozeni novych slozek
mkdir -p hw04/Zapis
mkdir -p hw04/Archiv

soubor="hw04/Zapis/datum_cas.txt"

echo "Datum a cas : $(date)" > "$soubor"


zip -r "hw04/Archiv/backup.zip" hw04/Zapis > /dev/null

echo "hotovo"
