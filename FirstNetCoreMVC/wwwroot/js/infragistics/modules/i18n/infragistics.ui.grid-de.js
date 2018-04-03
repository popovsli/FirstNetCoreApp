/*!@license
* Infragistics.Web.ClientUI Grid localization resources 17.2.456
*
* Copyright (c) 2011-2017 Infragistics Inc.
*
* http://www.infragistics.com/
*
*/
(function(factory){if(typeof define==="function"&&define.amd){define(["jquery"],factory)}else{return factory(jQuery)}})(function($){$.ig=$.ig||{};$.ig.locale=$.ig.locale||{};$.ig.locale.de=$.ig.locale.de||{};$.ig.Grid=$.ig.Grid||{};$.ig.locale.de.Grid={noSuchWidget:"{featureName}\xa0wurde nicht erkannt. \xdcberpr\xfcfen, dass eine solche Funktion existiert und die Schreibweise richtig ist.",autoGenerateColumnsNoRecords:"autoGenerateColumns ist aktiviert, aber es gibt keine Datens\xe4tze in der Datenquelle, um die Spalten zu bestimmen",optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",optionChangeNotScrollingGrid:"{optionName} kann nach der Initialisierung nicht bearbeitet werden, weil das Raster zu Beginn nicht abrollt und ein komplettes erneutes Rendering notwendig sein wird. Diese Option sollte w\xe4hrend der Initialisierung festgelegt werden.",widthChangeFromPixelsToPercentagesNotSupported:"Die Option Rasterbreite kann nicht dynamisch von Pixeln auf Prozente umgestellt werden.",widthChangeFromPercentagesToPixelsNotSupported:"Die Option Rasterbreite kann nicht dynamisch von Prozenten auf Pixel umgestellt werden.",noPrimaryKeyDefined:"Es wurde kein Prim\xe4rschl\xfcssel f\xfcr das Raster definiert. Um Features wie Grid Editing verwenden zu k\xf6nnen, muss ein Prim\xe4rschl\xfcssel definiert werden.",indexOutOfRange:"Der angegebene Reihenindex liegt au\xdferhalb des zul\xe4ssigen Bereichs. Ein Reihenindex zwischen {0} und {max} sollte zur Verf\xfcgung stehen.",noSuchColumnDefined:"Der angegebene Spaltenschl\xfcssel stimmt mit keiner der angegebenen Rasterspalten \xfcberein.",columnIndexOutOfRange:"Der angegebene Spaltenindex liegt au\xdferhalb des zul\xe4ssigen Bereichs. Ein Spaltenindex zwischen {0} und {max} sollte zur Verf\xfcgung stehen.",recordNotFound:"Ein Datensatz mit ID {id} konnte in der Datenansicht nicht gefunden werden. \xdcberpr\xfcfen Sie die ID, die f\xfcr die Suche verwendet wurde, und passen Sie sie, wenn n\xf6tig, an.",columnNotFound:"Eine Spalte mit Schl\xfcssel {key} konnte nicht gefunden werden. \xdcberpr\xfcfen Sie den Schl\xfcssel, der f\xfcr die Suche verwendet wurde, und passen Sie ihn, wenn n\xf6tig, an.",colPrefix:"Spalte ",columnVirtualizationRequiresWidth:"Virtualisierung / columnVirtualization ist auf True festgelegt, es konnte jedoch keine Breite f\xfcr die Rasterspalten abgeleitet werden. Legen Sie entweder a) Rasterbreite oder b) defaultColumnWidth fest oder c) definieren Sie die Breite f\xfcr jede Spalte",virtualizationRequiresHeight:"Virtualisierung ist auf True festgelegt, daher muss auch die Rasterh\xf6he festgelegt werden.",colVirtualizationDenied:"columnVirtualization gilt nur f\xfcr feste Virtualisierung",noColumnsButAutoGenerateTrue:"autoGenerateColumns ist auf False festgelegt, im Raster sind jedoch keine Spalten definiert. Bitte legen Sie autoGenerateColumns auf True fest oder geben Sie manuell Spalten an",templatingEnabledButNoTemplate:"jQueryTemplating ist auf True festgelegt, es ist jedoch kein rowTemplate definiert.",expandTooltip:"Zeile erweitern",collapseTooltip:"Zeile reduzieren",movingNotAllowedOrIncompatible:"Das Verschieben der angeforderten Spalte konnte nicht abgeschlossen werden. Die Spalte wurde nicht gefunden oder das Ergebnis war nicht mit dem Spaltenlayout kompatibel.",allColumnsHiddenOnInitialization:"Es k\xf6nnen nicht alle Rasterspalten ausgeblendet werden. Bitte stellen Sie mindestens eine der Spalten so ein, dass sie angezeigt wird.",virtualizationNotSupportedWithAutoSizeCols:"Die Virtualisierung erfordert eine andere Spaltenbreiten-Konfiguration als '*'. Die Spaltenbreite sollte als Pixelzahl eingestellt sein.",columnVirtualizationNotSupportedWithPercentageWidth:"Die Spaltenvirtualisierung wird nicht unterst\xfctzt wenn die Rasterbreite in der Einheit Prozent angegeben wird.",mixedWidthsNotSupported:"Gemischte/partielle Einstellungen der Spaltenbreite werden nicht unterst\xfctzt. Es werden keine Szenarien unterst\xfctzt, bei denen einige Spaltenbreiten in Prozent eingestellt sind, w\xe4hrend andere in Pixel eingestellt sind (oder gar nicht angegeben werden).",multiRowLayoutColumnError:"Die Spalte mit dem Schl\xfcssel: {key1} konnte nicht zum mehrzeiligen Layout hinzugef\xfcgt werden, da ihr Platz im Layout bereits von der Spalte mit dem Schl\xfcssel: {key2} eingenommen wurde.",multiRowLayoutNotComplete:"Das mehrzeilige Layout ist nicht vollst\xe4ndig. Die Spaltendefinition erstellt ein Layout mit Leerr\xe4umen, das nicht korrekt gerendert werden kann.",multiRowLayoutMixedWidths:"Vermischte Breiten (Prozent und Pixel) werden im Multi-Row Layout nicht unterst\xfctzt. Definieren Sie bitte alle Spaltenbreiten in Pixeln oder Prozent. ",multiRowLayoutHidingNotSupported:"Das mehrzeilige Layout unterst\xfctzt keine ausgeblendeten Spalten. Das mehrzeilige Layout unterst\xfctzt keine ausgeblendeten Spalten.Bitte entfernen Sie ausgeblendete Spalten aus den Spaltendefinitionen.",scrollableGridAreaNotVisible:"Fixierte Kopf- und Fu\xdfzeilenbereiche sind gr\xf6\xdfer als die verf\xfcgbare Rasterh\xf6he. Der verschiebbare Bereich ist nicht sichtbar. Legen Sie bitte eine gr\xf6\xdfere Rasterh\xf6he fest.",featureNotSupportedWithMRL:"{featureName} wird von mehrzeiligem Layout nicht unterst\xfctzt. Bitte entfernen Sie die Funktion aus der Funktionsliste."};$.ig.HierarchicalGrid=$.ig.HierarchicalGrid||{};$.ig.locale.de.HierarchicalGrid={noPrimaryKey:"F\xfcr das igHierarchicalGrid Widget muss ein Prim\xe4rschl\xfcssel definiert werden.",expandTooltip:"Zeile erweitern",collapseTooltip:"Zeile reduzieren"};$.ig.GridFeatureChooser=$.ig.GridFeatureChooser||{};$.ig.locale.de.GridFeatureChooser={featureChooserTooltip:"Featureauswahl"};$.ig.GridFiltering=$.ig.GridFiltering||{};$.ig.locale.de.GridFiltering={optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",startsWithNullText:"Beginnt mit...",endsWithNullText:"Endet mit...",containsNullText:"Enth\xe4lt...",doesNotContainNullText:"Enth\xe4lt nicht...",equalsNullText:"Gleich...",doesNotEqualNullText:"Nicht gleich...",greaterThanNullText:"Gr\xf6\xdfer als...",lessThanNullText:"Kleiner als...",greaterThanOrEqualToNullText:"Gr\xf6\xdfer als oder gleich...",lessThanOrEqualToNullText:"Kleiner als oder gleich...",onNullText:"Am...",notOnNullText:"Nicht am...",afterNullText:"Nach",beforeNullText:"Vor",emptyNullText:"Leer",notEmptyNullText:"Nicht leer",nullNullText:"Null",notNullNullText:"Nicht Null",startsWithLabel:"Beginnt mit",endsWithLabel:"Endet mit",containsLabel:"Enth\xe4lt",doesNotContainLabel:"Enth\xe4lt nicht",equalsLabel:"Gleich",doesNotEqualLabel:"Nicht gleich",greaterThanLabel:"Gr\xf6\xdfer als",lessThanLabel:"Kleiner als",greaterThanOrEqualToLabel:"Gr\xf6\xdfer als oder gleich",lessThanOrEqualToLabel:"Kleiner als oder gleich",trueLabel:"Wahr",falseLabel:"Falsch",afterLabel:"Nach",beforeLabel:"Vor",todayLabel:"Heute",yesterdayLabel:"Gestern",thisMonthLabel:"Dieser Monat",lastMonthLabel:"Letzter Monat",nextMonthLabel:"N\xe4chster Monat",thisYearLabel:"Dieses Jahr",lastYearLabel:"Letztes Jahr",nextYearLabel:"N\xe4chstes Jahr",clearLabel:"Filter l\xf6schen",noFilterLabel:"Kein",onLabel:"Am",notOnLabel:"Nicht am",advancedButtonLabel:"Erweitert",filterDialogCaptionLabel:"ERWEITERTER FILTER",filterDialogConditionLabel1:"Datens\xe4tze anzeigen, die \xfcbereinstimmen mit ",filterDialogConditionLabel2:" der folgenden Kriterien",filterDialogConditionDropDownLabel:"Filterbedingung",filterDialogOkLabel:"Suchen",filterDialogCancelLabel:"Abbrechen",filterDialogAnyLabel:"ANY",filterDialogAllLabel:"ALL",filterDialogAddLabel:"Hinzuf\xfcgen",filterDialogErrorLabel:"Maximale Filterzahl \xfcberschritten",filterDialogCloseLabel:"Filterdialog schlie\xdfen",filterSummaryTitleLabel:"Suchergebnisse",filterSummaryTemplate:"${matches} \xfcbereinstimmende Datens\xe4tze",filterDialogClearAllLabel:"ALL l\xf6schen",tooltipTemplate:"${condition} Filter angewendet",featureChooserText:"Filter ausblenden",featureChooserTextHide:"Filter anzeigen",featureChooserTextAdvancedFilter:"Erweiterter Filter",virtualizationSimpleFilteringNotAllowed:"Wenn die horizontale Virtualisierung aktiviert ist, wird die einfache Filterung (Filterzeile) nicht unterst\xfctzt. Bitte legen Sie den Modus auf 'erweitert' fest und/oder aktivieren Sie advancedModeEditorsVisible nicht",multiRowLayoutSimpleFilteringNotAllowed:"Mehrzeiliges Layout erfordert einen anderen Filtertyp. Stellen Sie den Filtermodus auf \u201eadvanced\u201c",featureChooserNotReferenced:"Featureauswahl-Skript ist nicht referenziert. Um den Erhalt dieser Fehlermeldung zu vermeiden, schlie\xdfen Sie bitte die Datei ig.ui.grid.featurechooser.js ein oder verwenden Sie das Ladeprogramm oder eine der kombinierten Skript-Dateien.",conditionListLengthCannotBeZero:"Das Array f\xfcr die conditionList in columnSettings ist leer. Ein passendes Array f\xfcr die conditionList sollte zur Verf\xfcgung stehen.",conditionNotValidForColumnType:"Die Bedingung '{0}' gilt nicht f\xfcr die aktuelle Konfiguration. Sie sollte durch eine Bedingung ersetzt werden, die zum Spaltentyp {1} passt.",defaultConditionContainsInvalidCondition:"defaultExpression f\xfcr Spalte '{0}' enth\xe4lt eine unerlaubte Bedingung. Sie sollte durch eine Bedingung ersetzt werden, die zum Spaltentyp {0} passt."};$.ig.GridGroupBy=$.ig.GridGroupBy||{};$.ig.locale.de.GridGroupBy={optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",emptyGroupByAreaContent:"Ziehen Sie eine Spalte hierher oder {0} zu Gruppiert nach",emptyGroupByAreaContentSelectColumns:"Spalten ausw\xe4hlen",emptyGroupByAreaContentSelectColumnsCaption:"Spalten ausw\xe4hlen",expandTooltip:"Gruppierte Zeile erweitern",collapseTooltip:"Gruppierte Zeile reduzieren",removeButtonTooltip:"Gruppierte Spalte entfernen",modalDialogCaptionButtonDesc:"Klicken, um aufsteigend zu sortieren",modalDialogCaptionButtonAsc:"Klicken, um absteigend zu sortieren",modalDialogCaptionButtonUngroup:"Klicken, um Gruppierung aufzuheben",modalDialogGroupByButtonText:"Gruppieren nach",modalDialogCaptionText:"Zu Gruppieren nach hinzuf\xfcgen",modalDialogDropDownLabel:"Anzeige:",modalDialogClearAllButtonLabel:"Alle l\xf6schen",modalDialogRootLevelHierarchicalGrid:"Stamm",modalDialogDropDownButtonCaption:"Klicken, um anzuzeigen/auszublenden",modalDialogButtonApplyText:"\xdcbernehmen",modalDialogButtonCancelText:"Abbrechen",fixedVirualizationNotSupported:"Die GroupBy-Funktion funktioniert nicht bei der fixierten Virtualisierung.",summaryRowTitle:"Gruppierungszusammenfassungszeile",summaryIconTitle:"Auswahl f\xfcr {0}: {1}"};$.ig.GridHiding=$.ig.GridHiding||{};$.ig.locale.de.GridHiding={optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",columnChooserDisplayText:"Spaltenwahl",hiddenColumnIndicatorTooltipText:"Ausgeblendete Spalte(n)",columnHideText:"Ausblenden",columnChooserCaptionLabel:"Spaltenauswahl",columnChooserCheckboxesHeader:"Ansicht",columnChooserColumnsHeader:"Spalte",columnChooserCloseButtonTooltip:"Schlie\xdfen",hideColumnIconTooltip:"Ausblenden",featureChooserNotReferenced:"Featureauswahl-Skript ist nicht referenziert. Um den Erhalt dieser Fehlermeldung zu vermeiden, schlie\xdfen Sie bitte die Datei ig.ui.grid.featurechooser.js ein oder verwenden Sie eine der kombinierten Skript-Dateien.",columnChooserShowText:"Anzeigen",columnChooserHideText:"Ausblenden",columnChooserResetButtonLabel:"Zur\xfccksetzen",columnChooserButtonApplyText:"\xdcbernehmen",columnChooserButtonCancelText:"Abbrechen"};$.ig.GridResizing=$.ig.GridResizing||{};$.ig.locale.de.GridResizing={optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",noSuchVisibleColumn:"Mit dem angegebenen Schl\xfcssel konnte keine sichtbare Spalte gefunden werden. Sie k\xf6nnen nur die Gr\xf6\xdfe sichtbarer Spalten \xe4ndern.",resizingAndFixedVirtualizationNotSupported:"Die Funktion zur Gr\xf6\xdfen\xe4nderung funktioniert nicht, wenn bei fixiertem virtualizationMode entweder die Virtualisierung oder die Spaltenvirtualisierung aktiviert ist. Um diese Ausnahme zu verhindern stellen Sie virtualizationMode bitte auf 'continuous' oder verwenden Sie nur rowVirtualization."};$.ig.GridPaging=$.ig.GridPaging||{};$.ig.locale.de.GridPaging={optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",pageSizeDropDownLabel:"Anzeigen ",pageSizeDropDownTrailingLabel:"Datens\xe4tze",nextPageLabelText:"Weiter",prevPageLabelText:"Zur\xfcck",firstPageLabelText:"",lastPageLabelText:"",currentPageDropDownLeadingLabel:"S.",currentPageDropDownTrailingLabel:"von ${count}",currentPageDropDownTooltip:"Seitenindex ausw\xe4hlen",pageSizeDropDownTooltip:"Anzahl der Datens\xe4tze pro Seite ausw\xe4hlen",pagerRecordsLabelTooltip:"Aktueller Datensatzbereich",prevPageTooltip:"Zur vorherigen Seite wechseln",nextPageTooltip:"Zur n\xe4chsten Seite wechseln",firstPageTooltip:"Zur ersten Seite wechseln",lastPageTooltip:"Zur letzten Seite wechseln",pageTooltipFormat:"Seite ${index}",pagerRecordsLabelTemplate:"${startRecord} - ${endRecord} von ${recordCount} Datens\xe4tzen",invalidPageIndex:"Ung\xfcltiger Seitenindex - er sollte gr\xf6\xdfer oder gleich 0 und niedriger als die Seitenzahl sein"};$.ig.GridSelection=$.ig.GridSelection||{};$.ig.locale.de.GridSelection={optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",persistenceImpossible:"F\xfcr die dauerhafte Auswahl zwischen Zust\xe4nden ist es erforderlich, dass die igGrid's primaryKey-Option eingestellt ist. Um den Erhalt dieses Fehlers zu vermeiden definieren Sie bitte einen primary key oder deaktivieren Sie die Dauerhaftigkeit."};$.ig.GridRowSelectors=$.ig.GridRowSelectors||{};$.ig.locale.de.GridRowSelectors={optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",selectionNotLoaded:"igGridSelection ist nicht initialisiert. Um den Erhalt dieser Fehlermeldung zu vermeiden, aktivieren Sie bitte das Feature Selection f\xfcr das Raster oder legen Sie die Eigenschaft requireSelection property der Funktion Row Selectors auf False fest.",columnVirtualizationEnabled:"igGridRowSelectors wird bei aktivierter Spaltenvirtualisierung nicht unterst\xfctzt. Verwenden Sie rowVirtualization oder stellen Sie den virtualizationMode auf 'continuous'.",selectedRecordsText:"Sie haben ${checked} Datens\xe4tze ausgew\xe4hlt.",deselectedRecordsText:"Sie haben die Auswahl von ${unchecked} Datens\xe4tzen aufgehoben.",selectAllText:"W\xe4hlen Sie alle ${totalRecordsCount} Datens\xe4tze aus",deselectAllText:"Heben Sie die Auswahl von allen ${totalRecordsCount} Datens\xe4tzen auf",requireSelectionWithCheckboxes:"Eine Auswahl ist erforderlich, wenn aktivierte Kontrollk\xe4stchen vorhanden sind"};$.ig.GridSorting=$.ig.GridSorting||{};$.ig.locale.de.GridSorting={optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",sortedColumnTooltip:"sortiert ${direction}",unsortedColumnTooltip:"Klicken, um Spalte zu sortieren",ascending:"aufsteigend",descending:"absteigend",modalDialogSortByButtonText:"Sortieren nach",modalDialogResetButton:"Zur\xfccksetzen",modalDialogCaptionButtonDesc:"Klicken, um absteigend zu sortieren",modalDialogCaptionButtonAsc:"Klicken, um aufsteigend zu sortieren",modalDialogCaptionButtonUnsort:"Klicken, um Sortierung zu entfernen",featureChooserText:"Mehrere sortieren",modalDialogCaptionText:"Mehrere sortieren",modalDialogButtonApplyText:"\xdcbernehmen",modalDialogButtonCancelText:"Abbrechen",sortingHiddenColumnNotSupport:"Sortierung von ausgeblendeten Spalten wird nicht unterst\xfctzt",featureChooserSortAsc:"Aufsteigend sortieren",featureChooserSortDesc:"Absteigend sortieren"};$.ig.GridSummaries=$.ig.GridSummaries||{};$.ig.locale.de.GridSummaries={optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",featureChooserText:"\xdcbersicht ausblenden",featureChooserTextHide:"\xdcbersicht anzeigen",dialogButtonOKText:"OK",dialogButtonCancelText:"Abbrechen",emptyCellText:"",summariesHeaderButtonTooltip:"Zusammenfassungen anzeigen/ausblenden",defaultSummaryRowDisplayLabelCount:"Anzahl",defaultSummaryRowDisplayLabelMin:"Min",defaultSummaryRowDisplayLabelMax:"Max",defaultSummaryRowDisplayLabelSum:"Summe",defaultSummaryRowDisplayLabelAvg:"Durchschnitt",defaultSummaryRowDisplayLabelCustom:"Benutzerdefiniert",calculateSummaryColumnKeyNotSpecified:"Bitte geben Sie den Spaltenschl\xfcssel f\xfcr die Berechnung der Zusammenfassung an",featureChooserNotReferenced:"Featureauswahl-Skript ist nicht referenziert. Um den Erhalt dieser Fehlermeldung zu vermeiden, schlie\xdfen Sie bitte die Datei ig.ui.grid.featurechooser.js ein oder verwenden Sie eine der kombinierten Skript-Dateien."};$.ig.GridUpdating=$.ig.GridUpdating||{};$.ig.locale.de.GridUpdating={optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",doneLabel:"Fertig",doneTooltip:"Bearbeitung beenden und aktualisieren",cancelLabel:"Abbrechen",cancelTooltip:"Bearbeitung beenden und nicht aktualisieren",addRowLabel:"Neue Zeile hinzuf\xfcgen",addRowTooltip:"Klicken, um eine neue Zeile hinzuzuf\xfcgen",deleteRowLabel:"Zeile l\xf6schen",deleteRowTooltip:"Zeile l\xf6schen",igTextEditorException:"Es ist momentan nicht m\xf6glich, Zeichenfolgen-Spalten im Raster zu aktualisieren. ui.igTextEditor sollte zuerst geladen werden.",igNumericEditorException:"Es ist momentan nicht m\xf6glich, numerische Spalten im Raster zu aktualisieren. ui.igNumericEditor sollte zuerst geladen werden.",igCheckboxEditorException:"Es ist momentan nicht m\xf6glich, Kontrollk\xe4stchen-Spalten im Raster zu aktualisieren. ui.igCheckboxEditor sollte zuerst geladen werden.",igCurrencyEditorException:"Es ist momentan nicht m\xf6glich, numerische Spalten mit W\xe4hrungsformat im Raster zu aktualisieren. ui.igCurrencyEditor sollte zuerst geladen werden.",igPercentEditorException:"Es ist momentan nicht m\xf6glich, numerische Spalten mit Prozentformat im Raster zu aktualisieren. ui.igPercentEditor sollte zuerst geladen werden.",igDateEditorException:"Es ist momentan nicht m\xf6glich, Daten-Spalten im Raster zu aktualisieren. ui.igDateEditor sollte zuerst geladen werden.",igDatePickerException:"Es ist momentan nicht m\xf6glich, Daten-Spalten im Raster zu aktualisieren. ui.igDatePicker sollte zuerst geladen werden.",igComboException:"Um den Kombinationstyp f\xfcr ui.igGrid zu verwenden, muss ui.igCombo geladen werden",igRatingException:"Um igRating als Editor f\xfcr ui.igGrid zu verwenden, muss ui.igRating geladen werden",igValidatorException:"F\xfcr die in igGridUpdating definierten \xdcberpr\xfcfungsoptionen muss ui.igValidator geladen werden",editorTypeCannotBeDetermined:"Bei der Aktualisierung waren nicht gen\xfcgend Informationen zur richtigen Bestimmung des f\xfcr die Spalte zu verwendenden Editortyps vorhanden: ",noPrimaryKeyException:'Um Aktualisierungsvorg\xe4nge zu unterst\xfctzen, nachdem eine Zeile gel\xf6scht wurde, muss die Anwendung "primaryKey" in Optionen von igGrid definieren.',hiddenColumnValidationException:"Eine Zeile mit ausgeblendeter Spalte mit aktivierter \xdcberpr\xfcfung kann nicht bearbeitet werden.",dataDirtyException:'Raster hat ausstehende Transaktionen, die das Rendern der Daten beeinflussen k\xf6nnen Um eine Ausnahme zu vermeiden, kann die Anwendung die Option "autoCommit" von igGrid aktivieren oder sie muss das Ereignis "dataDirty" von igGridUpdating verarbeiten und False zur\xfcckgeben. Bei der Verarbeitung dieses Ereignisses kann die Anwendung auch "commit()" Daten in igGrid durchf\xfchren.',recordOrPropertyNotFoundException:"Der angegebene Datensatz oder die angegebene Eigenschaft wurde nicht gefunden. \xdcberpr\xfcfen Sie die Kriterien f\xfcr Ihre Suche und passen Sie sie, wenn n\xf6tig, an.",rowEditDialogCaptionLabel:"Zeilendaten bearbeiten",excelNavigationNotSupportedWithCurrentEditMode:'ExcelNavigation erfordert eine andere Konfiguration. editMode sollte auf "cell" oder "row" eingestellt werden.',columnNotFound:"Der angegebene Spaltenschl\xfcssel wurde nicht in der sichtbaren Spaltenauflistung gefunden oder der angegebene Index lag au\xdferhalb des zul\xe4ssigen Bereichs.",rowOrColumnSpecifiedOutOfView:"Das Bearbeiten der angegebenen Reihe oder Spalte ist momentan nicht m\xf6glich. Es sollte auf der aktuellen Seite und im Virtualisierungsrahmen ersichtlich sein.",editingInProgress:"Eine Reihe oder Zelle wird gerade bearbeitet. Ein anderer Aktualisierungsprozess kann nicht starten, bevor die aktuelle Bearbeitung beendet ist.",undefinedCellValue:"Nicht definiert, kann nicht als Zellenwert festgelegt werden.",addChildTooltip:"Tochterzeile hinzuf\xfcgen",multiRowGridNotSupportedWithCurrentEditMode:"Wenn mehrzeiliges Layout f\xfcr das Raster aktiviert ist, wird lediglich der Dialogbearbeitungsmodus unterst\xfctzt.",virtualizationNotSupportedWithoutAutoCommit:"Die Aktivierung von Aktualisierung und Virtualisierung wird nicht unterst\xfctzt, wenn autoCommit auf Falsch festgelegt ist. Bitte aktivieren Sie die Option autoCommit des Rasters."};$.ig.CellMerging=$.ig.CellMerging||{};$.ig.locale.de.CellMerging={optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",mergeStrategyNotAFunction:"The mergeStrategy specified is not recognized as a valid pre-defined value or a function with this name is not found."};$.ig.ColumnMoving=$.ig.ColumnMoving||{};$.ig.locale.de.ColumnMoving={optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",movingDialogButtonApplyText:"\xdcbernehmen",movingDialogButtonCancelText:"Abbrechen",movingDialogCaptionButtonDesc:"Nach unten verschieben",movingDialogCaptionButtonAsc:"Nach oben verschieben",movingDialogCaptionText:"Spalten verschieben",movingDialogDisplayText:"Spalten verschieben",movingDialogDropTooltipText:"Hierher verschieben",movingDialogCloseButtonTitle:"Verschiebungsdialog schlie\xdfen",dropDownMoveLeftText:"Nach links verschieben",dropDownMoveRightText:"Nach rechts verschieben",dropDownMoveFirstText:"Erste verschieben",dropDownMoveLastText:"Letzte verschieben",featureChooserNotReferenced:"Featureauswahl-Skript ist nicht referenziert. Um den Erhalt dieser Fehlermeldung zu vermeiden, schlie\xdfen Sie bitte die Datei ig.ui.grid.featurechooser.js ein oder verwenden Sie das Ladeprogramm oder eine der kombinierten Skript-Dateien.",movingToolTipMove:"Verschieben",featureChooserSubmenuText:"Verschieben",columnVirtualizationEnabled:"Das Verschieben von Spalten erfordert eine andere Virtualisierungskonfiguration. Verwenden Sie rowVirtualization oder stellen Sie den virtualizationMode auf 'continuous'."};$.ig.ColumnFixing=$.ig.ColumnFixing||{};$.ig.locale.de.ColumnFixing={optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",headerFixButtonText:"Klicken, um diese Spalte zu binden",headerUnfixButtonText:"Klicken, um diese Spalte zu l\xf6sen",featureChooserTextFixedColumn:"Spalte befestigen",featureChooserTextUnfixedColumn:"Spalte l\xf6sen",groupByNotSupported:"igGridGroupBy wird nicht von ColumnFixing unterst\xfctzt",virtualizationNotSupported:"Die Optionsvirtualisierung des Rasters erm\xf6glicht die Virtualisierung von Zeilen und Spalten. Bei ColumnFixing wird die Spaltenvirtualisierung nicht unterst\xfctzt. Bitte aktivieren Sie die Option rowVirtualization des Rasters",columnVirtualizationNotSupported:"Bei ColumnFixing wird die Spaltenvirtualisierung nicht unterst\xfctzt",columnMovingNotSupported:"igGridColumnMoving wird nicht von ColumnFixing unterst\xfctzt",hidingNotSupported:"igGridHiding wird nicht von ColumnFixing unterst\xfctzt",hierarchicalGridNotSupported:"igHierarchicalGrid wird nicht von ColumnFixing unterst\xfctzt",responsiveNotSupported:"igGridResponsive wird nicht von ColumnFixing unterst\xfctzt",noGridWidthNotSupported:"ColumnFixing erfordert eine andere Konfiguration. Die Rasterbreite muss entweder als Prozentsatz oder als Pixelanzahl eingestellt werden.",gridHeightInPercentageNotSupported:"ColumnFixing erfordert eine andere Konfiguration. Die Rasterh\xf6he muss in Pixeln eingestellt werden.",defaultColumnWidthInPercentageNotSupported:"Bei der Verwendung von ColumnFixing wird die standardm\xe4\xdfige Spaltenbreite in Prozent nicht unterst\xfctzt",columnsWidthShouldBeSetInPixels:"ColumnFixing erfordert eine andere Spaltenbreiten-Konfiguration. Die Spaltenbreite mit Schl\xfcssel {key} sollte in Pixeln eingestellt sein.",unboundColumnsNotSupported:"Bei ungebundenen Spalten wird ColumnFixing nicht unterst\xfctzt",excelNavigationNotSupportedWithCurrentEditMode:"Der Excel-Navigationsmodus wird nur f\xfcr die Modi zur Bearbeitung der Zellen und der Zeilen unterst\xfctzt. Um diesen Fehler zu verhindern deaktivieren Sie excelNavigationMode oder stellen Sie den editMode auf Zelle oder Zeile ein.",initialFixingNotApplied:"Das anf\xe4ngliche Fixieren konnte bei der Spalte mit folgendem Schl\xfcssel nicht angewendet werden: {0}. Grund: {1}",setOptionGridWidthException:"Falscher Wert f\xfcr Option Rasterbreite. Wenn fixierte Spalten vorliegen, muss die Breite des sichtbaren Bereichs nicht fixierter Spalten gr\xf6\xdfer als oder gleich dem Wert f\xfcr minimalVisibleAreaWidth sein.",noneError:"Kein Fehler",notValidIdentifierError:"Es gibt keine Spalte mit dem angegebenen Bezeichner",fixingRefusedError:"Das Fixieren wird verweigert, da es nur EINE sichtbare gel\xf6ste Spalte gibt",fixingRefusedMinVisibleAreaWidthError:"Aufgrund der Mindestbreite des sichtbaren Bereichs f\xfcr gel\xf6ste Spalten ist das Fixieren der Spalte nicht erlaubt",alreadyHiddenError:"Sie versuchen, eine ausgeblendete Spalte zu fixieren oder zu l\xf6sen",alreadyUnfixedError:"Die Spalte, die Sie l\xf6sen wollen, ist bereits gel\xf6st",alreadyFixedError:"Die Spalte, die Sie fixieren wollen, ist bereits fixiert",unfixingRefusedError:"Das L\xf6sen wird verweigert, da es nur eine sichtbare fixierte Spalte und mindestens eine ausgeblendete fixierte Spalte gibt.",targetNotFoundError:"Zielspalte mit Schl\xfcssel {key} konnte nicht gefunden werden. \xdcberpr\xfcfen Sie den Schl\xfcssel, der f\xfcr die Suche verwendet wurde, und passen Sie ihn, wenn n\xf6tig, an."};$.ig.GridAppendRowsOnDemand=$.ig.GridAppendRowsOnDemand||{};$.ig.locale.de.GridAppendRowsOnDemand={optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",loadMoreDataButtonText:"Mehr Daten laden",appendRowsOnDemandRequiresHeight:"Die Funktion AppendRowsOnDemand erfordert H\xf6he",groupByNotSupported:"igGridGroupBy wird nicht mit AppendRowsOnDemand unterst\xfctzt",pagingNotSupported:"igGridPaging wird nicht mit AppendRowsOnDemand unterst\xfctzt",cellMergingNotSupported:"igGridCellMerging wird nicht mit AppendRowsOnDemand unterst\xfctzt",virtualizationNotSupported:"Virtualisierung wird nicht mit AppendRowsOnDemand unterst\xfctzt"};$.ig.igGridResponsive=$.ig.igGridResponsive||{};$.ig.locale.de.igGridResponsive={optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",fixedVirualizationNotSupported:"Bei der fixierten Virtualisierung wird igGridResponsive nicht unterst\xfctzt"};$.ig.igGridMultiColumnHeaders=$.ig.igGridMultiColumnHeaders||{};$.ig.locale.de.igGridMultiColumnHeaders={optionChangeNotSupported:"{optionName} kann nach der Initialisierung nicht bearbeitet werden. Ihr Wert sollte w\xe4hrend der Initialisierung festgelegt werden.",multiColumnHeadersNotSupportedWithColumnVirtualization:"Bei columnVirtualization wird die Funktion f\xfcr mehrspaltige Kopfzeilen nicht unterst\xfctzt",atLeastOneColumnShouldBeShownWhenCollapseOrExpand:"Es sollte mindestens eine Spalte angezeigt werden, wenn Sie mehrzeilige Kopfzeilen erweitern oder reduzieren.",collapsedColumnIconTooltip:"Erweitern",expandedColumnIconTooltip:"Reduzieren"};$.ig.Grid.locale=$.ig.Grid.locale||$.ig.locale.de.Grid;$.ig.GridFeatureChooser.locale=$.ig.GridFeatureChooser.locale||$.ig.locale.de.GridFeatureChooser;$.ig.GridFiltering.locale=$.ig.GridFiltering.locale||$.ig.locale.de.GridFiltering;$.ig.GridGroupBy.locale=$.ig.GridGroupBy.locale||$.ig.locale.de.GridGroupBy;$.ig.GridHiding.locale=$.ig.GridHiding.locale||$.ig.locale.de.GridHiding;$.ig.GridResizing.locale=$.ig.GridResizing.locale||$.ig.locale.de.GridResizing;$.ig.GridPaging.locale=$.ig.GridPaging.locale||$.ig.locale.de.GridPaging;$.ig.GridSelection.locale=$.ig.GridSelection.locale||$.ig.locale.de.GridSelection;$.ig.GridRowSelectors.locale=$.ig.GridRowSelectors.locale||$.ig.locale.de.GridRowSelectors;$.ig.GridSorting.locale=$.ig.GridSorting.locale||$.ig.locale.de.GridSorting;$.ig.GridSummaries.locale=$.ig.GridSummaries.locale||$.ig.locale.de.GridSummaries;$.ig.GridUpdating.locale=$.ig.GridUpdating.locale||$.ig.locale.de.GridUpdating;$.ig.CellMerging.locale=$.ig.CellMerging.locale||$.ig.locale.de.CellMerging;$.ig.ColumnMoving.locale=$.ig.ColumnMoving.locale||$.ig.locale.de.ColumnMoving;$.ig.ColumnFixing.locale=$.ig.ColumnFixing.locale||$.ig.locale.de.ColumnFixing;$.ig.GridAppendRowsOnDemand.locale=$.ig.GridAppendRowsOnDemand.locale||$.ig.locale.de.GridAppendRowsOnDemand;$.ig.igGridResponsive.locale=$.ig.igGridResponsive.locale||$.ig.locale.de.igGridResponsive;$.ig.igGridMultiColumnHeaders.locale=$.ig.igGridMultiColumnHeaders.locale||$.ig.locale.de.igGridMultiColumnHeaders;$.ig.HierarchicalGrid.locale=$.ig.HierarchicalGrid.locale||$.ig.locale.de.HierarchicalGrid;return $.ig.locale.de});