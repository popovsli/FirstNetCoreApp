/*!@license
* Infragistics.Web.ClientUI Grid localization resources 17.2.456
*
* Copyright (c) 2011-2017 Infragistics Inc.
*
* http://www.infragistics.com/
*
*/
(function(factory){if(typeof define==="function"&&define.amd){define(["jquery"],factory)}else{return factory(jQuery)}})(function($){$.ig=$.ig||{};$.ig.locale=$.ig.locale||{};$.ig.locale.fr=$.ig.locale.fr||{};$.ig.Grid=$.ig.Grid||{};$.ig.locale.fr.Grid={noSuchWidget:"{featureName} n\u2019a pas \xe9t\xe9 reconnu. V\xe9rifiez que cette fonctionnalit\xe9 existe et que l\u2019orthographe est correcte.",autoGenerateColumnsNoRecords:"L'option autoGenerateColumns est activ\xe9e, mais il n'y a aucune archive dans la source de donn\xe9es permettant de d\xe9terminer les colonnes",optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",optionChangeNotScrollingGrid:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation car votre grille initiale ne d\xe9file pas. Le re-rendering complet est n\xe9cessaire. Cette option doit \xeatre d\xe9finie pendant l\u2019initialisation.",widthChangeFromPixelsToPercentagesNotSupported:"Impossible de faire passer dynamiquement l'option de largeur de grille des pixels aux pourcentages.",widthChangeFromPercentagesToPixelsNotSupported:"Impossible de faire passer dynamiquement l'option de largeur de grille des pourcentages aux pixels.",noPrimaryKeyDefined:"Aucune cl\xe9 principale n'est d\xe9finie pour la grille. Pour utiliser les fonctions telles que Grid Editing, vous devez d\xe9finir une cl\xe9 principale.",indexOutOfRange:"L\u2019index de ligne sp\xe9cifi\xe9 est hors plage. Un index de ligne compris entre {0} et {max} doit \xeatre fourni.",noSuchColumnDefined:"La cl\xe9 de colonne sp\xe9cifi\xe9e ne co\xefncide avec aucune des colonnes d\xe9finies de la grille.",columnIndexOutOfRange:"L\u2019index de colonne sp\xe9cifi\xe9 est hors plage. Un index de colonne compris entre {0} et {max} doit \xeatre fourni.",recordNotFound:"Impossible de trouver l\u2019archive avec l\u2019id {id} dans la vue des donn\xe9es. V\xe9rifiez l\u2019id utilis\xe9 pour la recherche et modifiez-le si n\xe9cessaire.",columnNotFound:"La colonne avec la cl\xe9 {key} n\u2019a pas pu \xeatre trouv\xe9e. V\xe9rifiez la cl\xe9 utilis\xe9e pour la recherche et modifiez-la si n\xe9cessaire.",colPrefix:"Colonne ",columnVirtualizationRequiresWidth:"Virtualisation / columnVirtualization est d\xe9fini sur vrai, mais aucune largeur n'a pu \xeatre d\xe9duite pour les colonnes de la grille. Choisissez l'un des r\xe9glages a) largeur grille, b) defaultColumnWidth, c) d\xe9finir largeur pour chaque colonne",virtualizationRequiresHeight:"Virtualisation est d\xe9finie sur vrai, ce qui n\xe9cessite de d\xe9finir \xe9galement la hauteur de la grille.",colVirtualizationDenied:"columnVirtualization est applicable \xe0 la virtualisation fixe uniquement",noColumnsButAutoGenerateTrue:"L'option autoGenerateColumns est d\xe9finie sur faux, mais aucune colonne du tableau n'est d\xe9finie. D\xe9finissez l'option autoGenerateColumns sur vrai ou sp\xe9cifiez des colonnes manuellement",templatingEnabledButNoTemplate:"L'option jQueryTemplating est d\xe9finie sur vrai, mais aucun rowTemplate n'est d\xe9fini.",expandTooltip:"\xc9tendre la ligne",collapseTooltip:"R\xe9duire la ligne",movingNotAllowedOrIncompatible:"Impossible de d\xe9placer la colonne demand\xe9e. La colonne n'a pas \xe9t\xe9 trouv\xe9e ou le r\xe9sultat n'\xe9tait pas compatible avec la disposition des colonnes.",allColumnsHiddenOnInitialization:"Impossible de masquer toutes les colonnes de la grille. Veuillez d\xe9finir au moins une des colonnes \xe0 afficher.",virtualizationNotSupportedWithAutoSizeCols:"La virtualisation n\xe9cessite une configuration de largeur de colonne diff\xe9rente de \u2019*\u2019. La largeur de colonne doit \xeatre d\xe9finie avec un nombre de pixels.",columnVirtualizationNotSupportedWithPercentageWidth:"La virtualisation de colonne n'est pas prise en charge lorsque la largeur de grille est d\xe9finie en unit\xe9s de pourcentage.",mixedWidthsNotSupported:"Les param\xe8tres de largeur de colonne m\xe9lang\xe9s/partiels ne sont pas pris en charge. Les sc\xe9narios dans lesquels certaines largeurs de colonne sont d\xe9finies en pourcentage tandis que d'autres sont d\xe9finies en pixels (ou ne sont pas du tout d\xe9finies) ne sont pas pris en charge.",multiRowLayoutColumnError:"La colonne avec la touche {key1} n\u2019a pas pu \xeatre ajout\xe9e \xe0 la mise en page \xe0 lignes multiples car son emplacement dans la mise en page est d\xe9j\xe0 occup\xe9 par la colonne avec la touche {key2}.",multiRowLayoutNotComplete:"La mise en page \xe0 lignes multiples est incompl\xe8te. La d\xe9finition de colonne cr\xe9e une mise en page contenant des espaces vides et qui ne peut pas s\u2019afficher correctement.",multiRowLayoutMixedWidths:"Les largeurs mixtes (pourcentage et pixels) ne sont pas prises en charge pour la mise en page \xe0 lignes multiples. Configurez l\u2019ensemble des largeurs de colonne soit en pixels, soit en pourcentage. ",multiRowLayoutHidingNotSupported:"La mise en page \xe0 lignes multiples ne prend pas en charge les colonnes masqu\xe9es. Veuillez retirer les colonnes masqu\xe9es des d\xe9finitions de colonne.",scrollableGridAreaNotVisible:"Les zones d\u2019en-t\xeate et de pied de page fixes sont sup\xe9rieures \xe0 la hauteur de grille disponible. La zone de d\xe9filement n\u2019est pas visible. Configurez une plus grande hauteur de grille.",featureNotSupportedWithMRL:"{featureName} n\u2019est pas pris en charge par la mise en page \xe0 lignes multiples. Veuillez retirer la caract\xe9ristique de la liste des caract\xe9ristiques. "};$.ig.HierarchicalGrid=$.ig.HierarchicalGrid||{};$.ig.locale.fr.HierarchicalGrid={noPrimaryKey:"Le widget igHierarchicalGrid n\xe9cessite la d\xe9finition d'une cl\xe9 principale.",expandTooltip:"\xc9tendre la ligne",collapseTooltip:"R\xe9duire la ligne"};$.ig.GridFeatureChooser=$.ig.GridFeatureChooser||{};$.ig.locale.fr.GridFeatureChooser={featureChooserTooltip:"Choix de fonctionnalit\xe9"};$.ig.GridFiltering=$.ig.GridFiltering||{};$.ig.locale.fr.GridFiltering={optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",startsWithNullText:"Commence par...",endsWithNullText:"Finit par...",containsNullText:"Contient...",doesNotContainNullText:"Ne contient pas...",equalsNullText:"Est \xe9gal \xe0...",doesNotEqualNullText:"Est diff\xe9rent de...",greaterThanNullText:"Sup\xe9rieur \xe0...",lessThanNullText:"Inf\xe9rieur \xe0...",greaterThanOrEqualToNullText:"Sup\xe9rieur ou \xe9gal \xe0...",lessThanOrEqualToNullText:"Inf\xe9rieur ou \xe9gal \xe0...",onNullText:"Le...",notOnNullText:"Pas le...",afterNullText:"Apr\xe8s",beforeNullText:"Avant",emptyNullText:"Vide",notEmptyNullText:"Pas vide",nullNullText:"Nul",notNullNullText:"Pas nul",startsWithLabel:"Commence par",endsWithLabel:"Finit par",containsLabel:"Contient",doesNotContainLabel:"Ne contient pas",equalsLabel:"Est \xe9gal \xe0",doesNotEqualLabel:"Est diff\xe9rent de",greaterThanLabel:"Sup\xe9rieur \xe0",lessThanLabel:"Inf\xe9rieur \xe0",greaterThanOrEqualToLabel:"Sup\xe9rieur ou \xe9gal \xe0",lessThanOrEqualToLabel:"Inf\xe9rieur ou \xe9gal \xe0",trueLabel:"Vrai",falseLabel:"Faux",afterLabel:"Apr\xe8s",beforeLabel:"Avant",todayLabel:"Aujourd'hui",yesterdayLabel:"Hier",thisMonthLabel:"Ce mois",lastMonthLabel:"Mois pr\xe9c\xe9dent",nextMonthLabel:"Mois suivant",thisYearLabel:"Cette ann\xe9e",lastYearLabel:"Ann\xe9e pr\xe9c\xe9dente",nextYearLabel:"Ann\xe9e suivante",clearLabel:"Effacer le filtre",noFilterLabel:"Non",onLabel:"Le",notOnLabel:"Pas le",advancedButtonLabel:"Avanc\xe9",filterDialogCaptionLabel:"FILTRE AVANC\xc9",filterDialogConditionLabel1:"Afficher les rang\xe9es concordantes ",filterDialogConditionLabel2:" avec les crit\xe8res suivants",filterDialogConditionDropDownLabel:"Condition de filtre",filterDialogOkLabel:"Chercher",filterDialogCancelLabel:"Annuler",filterDialogAnyLabel:"N'IMPORTE LEQUEL",filterDialogAllLabel:"TOUS",filterDialogAddLabel:"Ajouter",filterDialogErrorLabel:"Nombre de filtres maximum exc\xe9d\xe9.",filterDialogCloseLabel:"Fermer le dialogue de filtre",filterSummaryTitleLabel:"R\xe9sultats de la recherche",filterSummaryTemplate:"${matches} rang\xe9es concordantes",filterDialogClearAllLabel:"Effacer tous",tooltipTemplate:"${condition} filtre appliqu\xe9",featureChooserText:"Masquer le filtre",featureChooserTextHide:"Afficher le filtre",featureChooserTextAdvancedFilter:"Filtre avanc\xe9",virtualizationSimpleFilteringNotAllowed:"Le filtrage simple (filtre ligne) n'est pas pris en compte si la virtualisation horizontale est activ\xe9e. Placez le mode sur 'avanc\xe9' et/ou n'activez pas advancedModeEditorsVisible",multiRowLayoutSimpleFilteringNotAllowed:"La mise en page \xe0 lignes multiples n\xe9cessite un autre type de filtrage. R\xe9glez le mode de filtrage sur 'advanced'",featureChooserNotReferenced:"Le script de choix de fonctionnalit\xe9 n'est pas r\xe9f\xe9renc\xe9. Pour \xe9viter de recevoir ce message d'erreur, veuillez inclure le fichier ig.ui.grid.featurechooser.js ou utiliser le chargeur ou utiliser l'un des fichiers de script combin\xe9.",conditionListLengthCannotBeZero:"Le tableau conditionList dans columnSettings est vide. Un tableau adapt\xe9 pour conditionList doit \xeatre fourni.",conditionNotValidForColumnType:"La condition \u2019{0}\u2019 n\u2019est pas valide pour la configuration actuelle. Elle doit \xeatre remplac\xe9e par une condition adapt\xe9e au type de colonne {1}.",defaultConditionContainsInvalidCondition:"defaultExpression pour la colonne \u2019{0}\u2019 contient une condition qui n\u2019est pas autoris\xe9e. Remplacez-la par une condition adapt\xe9e au type de colonne {0}."};$.ig.GridGroupBy=$.ig.GridGroupBy||{};$.ig.locale.fr.GridGroupBy={optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",emptyGroupByAreaContent:"Glissez une colonne ici ou {0} pour cr\xe9er des groupes",emptyGroupByAreaContentSelectColumns:"s\xe9lectionnez les colonnes",emptyGroupByAreaContentSelectColumnsCaption:"s\xe9lectionnez les colonnes",expandTooltip:"Etendre ligne group\xe9e",collapseTooltip:"R\xe9duire ligne group\xe9e",removeButtonTooltip:"Supprimer colonne group\xe9e",modalDialogCaptionButtonDesc:"Trier dans l'ordre croissant",modalDialogCaptionButtonAsc:"Trier dans l'ordre d\xe9croissant",modalDialogCaptionButtonUngroup:"Cliquez pour d\xe9grouper",modalDialogGroupByButtonText:"Grouper par",modalDialogCaptionText:"Ajouter \xe0 Grouper par",modalDialogDropDownLabel:"Affichage\xa0:",modalDialogClearAllButtonLabel:"Effacer tous",modalDialogRootLevelHierarchicalGrid:"racine",modalDialogDropDownButtonCaption:"Afficher/Masquer",modalDialogButtonApplyText:"Appliquer",modalDialogButtonCancelText:"Annuler",fixedVirualizationNotSupported:"La fonction GroupBy ne fonctionne pas avec la virtualisation verrouill\xe9e.",summaryRowTitle:"Groupement de la ligne r\xe9sum\xe9",summaryIconTitle:"R\xe9sum\xe9 pour {0}\xa0: {1}"};$.ig.GridHiding=$.ig.GridHiding||{};$.ig.locale.fr.GridHiding={optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",columnChooserDisplayText:"Choix de colonnes",hiddenColumnIndicatorTooltipText:"Colonnes masqu\xe9es",columnHideText:"Masquer",columnChooserCaptionLabel:"Choix de colonnes",columnChooserCheckboxesHeader:"vue",columnChooserColumnsHeader:"colonne",columnChooserCloseButtonTooltip:"Fermer",hideColumnIconTooltip:"Masquer",featureChooserNotReferenced:"Le script de choix de fonctionnalit\xe9 n'est pas r\xe9f\xe9renc\xe9. Pour \xe9viter de recevoir ce message d'erreur, veuillez inclure le fichier ig.ui.grille.choixfonctionnalit\xe9.js ou utiliser l'un des fichiers de script combin\xe9.",columnChooserShowText:"Afficher",columnChooserHideText:"Masquer",columnChooserResetButtonLabel:"R\xe9initialiser",columnChooserButtonApplyText:"Appliquer",columnChooserButtonCancelText:"Annuler"};$.ig.GridResizing=$.ig.GridResizing||{};$.ig.locale.fr.GridResizing={optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",noSuchVisibleColumn:"Aucune colonne visible correspondant \xe0 la cl\xe9 sp\xe9cifi\xe9e n'a \xe9t\xe9 trouv\xe9e. Vous pouvez uniquement redimensionner les colonnes visibles.",resizingAndFixedVirtualizationNotSupported:"La fonction de redimensionnement ne fonctionne pas lorsque la virtualisation ou bien la virtualisation de colonne est activ\xe9e avec le virtualizationMode verrouill\xe9. Pour emp\xeacher cette exception, veuillez d\xe9finir virtualizationMode sur 'continuous' ou utiliser uniquement rowVirtualization."};$.ig.GridPaging=$.ig.GridPaging||{};$.ig.locale.fr.GridPaging={optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",pageSizeDropDownLabel:"Afficher ",pageSizeDropDownTrailingLabel:"rang\xe9es",nextPageLabelText:"suiv",prevPageLabelText:"pr\xe9c",firstPageLabelText:"",lastPageLabelText:"",currentPageDropDownLeadingLabel:"Pg",currentPageDropDownTrailingLabel:"de ${count}",currentPageDropDownTooltip:"Choisir la page",pageSizeDropDownTooltip:"Choisir le nombre de rang\xe9es par page",pagerRecordsLabelTooltip:"Plage de rang\xe9es actuelle",prevPageTooltip:"Aller \xe0 la page pr\xe9c\xe9dente",nextPageTooltip:"Aller \xe0 la page suivante",firstPageTooltip:"Aller \xe0 la premi\xe8re page",lastPageTooltip:"Aller \xe0 la derni\xe8re page",pageTooltipFormat:"page ${index}",pagerRecordsLabelTemplate:"${startRecord} - ${endRecord} de ${recordCount} rang\xe9es",invalidPageIndex:"Index de page non valide - il doit \xeatre sup\xe9rieur ou \xe9gal \xe0 0 et doit \xeatre inf\xe9rieur au nombre de pages"};$.ig.GridSelection=$.ig.GridSelection||{};$.ig.locale.fr.GridSelection={optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",persistenceImpossible:"L'option primaryKey d'igGrid doit \xeatre d\xe9finie pour pouvoir r\xe9aliser une s\xe9lection persistante entre les \xe9tats. Pour \xe9viter d'obtenir cette erreur, veuillez d\xe9finir une cl\xe9 primaire ou d\xe9sactiver la persistance."};$.ig.GridRowSelectors=$.ig.GridRowSelectors||{};$.ig.locale.fr.GridRowSelectors={optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",selectionNotLoaded:"igGridSelection n'est pas initialis\xe9. Pour \xe9viter de recevoir ce message d'erreur, veuillez activer la fonctionnalit\xe9 S\xe9lection pour la grille ou d\xe9finir la propri\xe9t\xe9 requireSelection de la fonction de S\xe9lectionneurs de lignes sur faux.",columnVirtualizationEnabled:"igGridRowSelectors n'est pas pris en charge lorsque la virtualisation de colonne est activ\xe9e. Utilisez RowVirtualization ou r\xe9glez virtualizationMode sur 'continuous'.",selectedRecordsText:"Vous avez s\xe9lectionn\xe9 les archives ${checked}.",deselectedRecordsText:"Vous avez d\xe9s\xe9lectionn\xe9 les archives ${unchecked}.",selectAllText:"S\xe9lectionner toutes les archives ${totalRecordsCount}",deselectAllText:"D\xe9s\xe9lectionner toutes les archives ${totalRecordsCount}",requireSelectionWithCheckboxes:"La s\xe9lection est requise lorsque les cases \xe0 cocher sont activ\xe9es"};$.ig.GridSorting=$.ig.GridSorting||{};$.ig.locale.fr.GridSorting={optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",sortedColumnTooltip:"tri\xe9 ${direction}",unsortedColumnTooltip:"Cliquez pour trier la colonne",ascending:"dans l'ordre croissant",descending:"dans l'ordre d\xe9croissant",modalDialogSortByButtonText:"trier par",modalDialogResetButton:"r\xe9initialiser",modalDialogCaptionButtonDesc:"Trier dans l'ordre d\xe9croissant",modalDialogCaptionButtonAsc:"Trier dans l'ordre croissant",modalDialogCaptionButtonUnsort:"Annuler le tri",featureChooserText:"Trier selon Multiple",modalDialogCaptionText:"Trier Multiple",modalDialogButtonApplyText:"Appliquer",modalDialogButtonCancelText:"Annuler",sortingHiddenColumnNotSupport:"Le tri de la colonne masqu\xe9e n'est pas pris en charge",featureChooserSortAsc:"Trier de A \xe0 Z",featureChooserSortDesc:"Trier de Z \xe0 A"};$.ig.GridSummaries=$.ig.GridSummaries||{};$.ig.locale.fr.GridSummaries={optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",featureChooserText:"Masquer synth\xe8se",featureChooserTextHide:"Afficher synth\xe8se",dialogButtonOKText:"OK",dialogButtonCancelText:"Annuler",emptyCellText:"",summariesHeaderButtonTooltip:"Afficher/Masquer la synth\xe8se",defaultSummaryRowDisplayLabelCount:"Nombre",defaultSummaryRowDisplayLabelMin:"Min",defaultSummaryRowDisplayLabelMax:"Max",defaultSummaryRowDisplayLabelSum:"Total",defaultSummaryRowDisplayLabelAvg:"Moy",defaultSummaryRowDisplayLabelCustom:"Personnalis\xe9",calculateSummaryColumnKeyNotSpecified:"Indiquez la cl\xe9 de colonne pour calculer la synth\xe8se",featureChooserNotReferenced:"Le script de choix de fonctionnalit\xe9 n'est pas r\xe9f\xe9renc\xe9. Pour \xe9viter de recevoir ce message d'erreur, veuillez inclure le fichier g.ui.grid.featurechooser.js ou utiliser l'un des fichiers de script combin\xe9."};$.ig.GridUpdating=$.ig.GridUpdating||{};$.ig.locale.fr.GridUpdating={optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",doneLabel:"Termin\xe9",doneTooltip:"Arr\xeater l'\xe9dition et mettre \xe0 jour",cancelLabel:"Annuler",cancelTooltip:"Arr\xeater l'\xe9dition et ne pas mettre \xe0 jour",addRowLabel:"Ajouter une ligne",addRowTooltip:"Cliquez pour ajouter une ligne",deleteRowLabel:"Supprimer une ligne",deleteRowTooltip:"Supprimer une ligne",igTextEditorException:"Il est actuellement impossible d\u2019effectuer la mise \xe0 jour des colonnes de la cha\xeene dans la grille. ui.igTextEditor doit d\u2019abord \xeatre charg\xe9.",igNumericEditorException:"Il est actuellement impossible d\u2019effectuer la mise \xe0 jour des colonnes num\xe9riques dans la grille. ui.igNumericEditor doit d\u2019abord \xeatre charg\xe9.",igCheckboxEditorException:"Il est actuellement impossible d\u2019effectuer la mise \xe0 jour des colonnes des cases \xe0 cocher dans la grille. ui.igCheckboxEditor doit d\u2019abord \xeatre charg\xe9.",igCurrencyEditorException:"Il est actuellement impossible d\u2019effectuer la mise \xe0 jour des colonnes num\xe9riques avec un format mon\xe9taire dans la grille. ui.igCurrencyEditor doit d\u2019abord \xeatre charg\xe9.",igPercentEditorException:"Il est actuellement impossible d\u2019effectuer la mise \xe0 jour des colonnes num\xe9riques avec un format pourcentage dans la grille. ui.igPercentEditor doit d\u2019abord \xeatre charg\xe9.",igDateEditorException:"Il est actuellement impossible d\u2019effectuer la mise \xe0 jour des colonnes de date dans la grille. ui.igDateEditor doit d\u2019abord \xeatre charg\xe9.",igDatePickerException:"Il est actuellement impossible d\u2019effectuer la mise \xe0 jour des colonnes de date dans la grille. ui.igDatePicker doit d\u2019abord \xeatre charg\xe9.",igComboException:"Pour utiliser le type combo pour ui.igGrid, ui.igCombo doit \xeatre charg\xe9",igRatingException:"Pour utiliser le igRating comme \xe9diteur pour ui.igGrid, ui.igRating doit \xeatre charg\xe9",igValidatorException:"Les options de validation d\xe9finies dans igGridUpdating requi\xe8rent de charger ui.igValidator",editorTypeCannotBeDetermined:"La mise \xe0 jour n\u2019avait pas assez d\u2019informations pour d\xe9terminer correctement le type d\u2019\xe9diteur \xe0 utiliser pour la colonne\xa0: ",noPrimaryKeyException:"Pour la prise en charge des op\xe9rations de mise \xe0 jour apr\xe8s la suppression d'une ligne, l'application doit d\xe9finir la 'primaryKey' dans les options de igGrid.",hiddenColumnValidationException:"Impossible d'\xe9diter une ligne contenant une colonne masqu\xe9e avec la validation activ\xe9e.",dataDirtyException:"La grille contient des transactions en cours qui peuvent affecter le rendu des donn\xe9es. Pour \xe9viter l'exception, l'application peut activer l'option 'autoCommit' d'igGrid ou elle doit traiter l'\xe9v\xe9nement 'dataDirty' d'igGridUpdating et retourner la mention faux. Tout en traitant cet \xe9v\xe9nement, l'application peut aussi 'archiver()' les donn\xe9es dans igGrid.",recordOrPropertyNotFoundException:"L\u2019archive ou la propri\xe9t\xe9 sp\xe9cifi\xe9e est introuvable. V\xe9rifiez vos crit\xe8res de recherche et modifiez-les si n\xe9cessaire.",rowEditDialogCaptionLabel:"Editer les donn\xe9es de ligne",excelNavigationNotSupportedWithCurrentEditMode:"ExcelNavigation requiert une configuration diff\xe9rente. editMode doit \xeatre d\xe9fini sur \xab\xa0cell\xa0\xbb ou \xab\xa0row\xa0\xbb.",columnNotFound:"La cl\xe9 de colonne sp\xe9cifi\xe9e n\u2019a pas \xe9t\xe9 trouv\xe9e dans l\u2019ensemble des colonnes visibles ou l\u2019index sp\xe9cifi\xe9 \xe9tait hors plage.",rowOrColumnSpecifiedOutOfView:"L\u2019\xe9dition de la ligne ou de la colonne sp\xe9cifi\xe9e est actuellement impossible. Elle devrait s\u2019afficher dans la page actuelle et dans le cadre de virtualisation.",editingInProgress:"Une ligne ou une cellule est actuellement en cours d\u2019\xe9dition. Une autre proc\xe9dure de mise \xe0 jour ne peut \xeatre effectu\xe9e avant que l\u2019\xe9dition en cours ne soit termin\xe9e.",undefinedCellValue:'"Undefined" ne peut \xeatre d\xe9fini comme valeur de cellule.',addChildTooltip:"Ajouter une ligne enfant",multiRowGridNotSupportedWithCurrentEditMode:"Lorsque la mise en page \xe0 lignes multiples est activ\xe9e pour la grille, seul le mode d\u2019\xe9dition de dialogue est pris en charge.",virtualizationNotSupportedWithoutAutoCommit:"L\u2019activation de mise \xe0 jour et de virtualisation lorsque autoCommit est d\xe9fini sur faux n\u2019est pas prise en charge. Veuillez d\xe9finir l\u2019option autoCommit de la grille sur vrai."};$.ig.CellMerging=$.ig.CellMerging||{};$.ig.locale.fr.CellMerging={optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",mergeStrategyNotAFunction:"The mergeStrategy specified is not recognized as a valid pre-defined value or a function with this name is not found."};$.ig.ColumnMoving=$.ig.ColumnMoving||{};$.ig.locale.fr.ColumnMoving={optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",movingDialogButtonApplyText:"Appliquer",movingDialogButtonCancelText:"Annuler",movingDialogCaptionButtonDesc:"Descendre",movingDialogCaptionButtonAsc:"Monter",movingDialogCaptionText:"D\xe9placer les colonnes",movingDialogDisplayText:"D\xe9placer les colonnes",movingDialogDropTooltipText:"D\xe9placer ici",movingDialogCloseButtonTitle:"Fermer la bo\xeete de dialogue de d\xe9placement",dropDownMoveLeftText:"D\xe9placer vers la gauche",dropDownMoveRightText:"D\xe9placer vers la droite",dropDownMoveFirstText:"D\xe9placer en premier",dropDownMoveLastText:"D\xe9placer en dernier",featureChooserNotReferenced:"Le script de choix de fonctionnalit\xe9 n'est pas r\xe9f\xe9renc\xe9. Pour \xe9viter de recevoir ce message d'erreur, veuillez inclure le fichier ig.ui.grid.featurechooser.js ou utiliser le chargeur ou utiliser l'un des fichiers de script combin\xe9.",movingToolTipMove:"D\xe9placer",featureChooserSubmenuText:"D\xe9placer",columnVirtualizationEnabled:"Le d\xe9placement de colonne requiert un param\xe8tre de virtualisation diff\xe9rent. Utilisez RowVirtualization ou r\xe9glez virtualizationMode sur 'continuous'."};$.ig.ColumnFixing=$.ig.ColumnFixing||{};$.ig.locale.fr.ColumnFixing={optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",headerFixButtonText:"Cliquer pour verrouiller cette colonne",headerUnfixButtonText:"Cliquer pour d\xe9verrouiller cette colonne",featureChooserTextFixedColumn:"Verrouiller colonne",featureChooserTextUnfixedColumn:"D\xe9tacher colonne",groupByNotSupported:"igGridGroupBy n'est pas pris en charge avec ColumnFixing",virtualizationNotSupported:"L'option de virtualisation de la grille permet la virtualisation de ligne et de colonne. La virtualisation de colonne n'est pas prise en charge avec ColumnFixing. Veuillez d\xe9finir l'option rowVirtualization de la grille sur vrai",columnVirtualizationNotSupported:"La virtualisation de colonne n'est pas prise en charge avec ColumnFixing",columnMovingNotSupported:"igGridColumnMoving n'est pas pris en charge avec ColumnFixing",hidingNotSupported:"igGridHiding n'est pas pris en charge avec ColumnFixing",hierarchicalGridNotSupported:"igHierarchicalGrid n'est pas pris en charge avec ColumnFixing",responsiveNotSupported:"igGridResponsive n'est pas pris en charge avec ColumnFixing",noGridWidthNotSupported:"La fixation de colonne n\xe9cessite une configuration diff\xe9rente. La largeur de la grille doit \xeatre r\xe9gl\xe9e en pourcentage ou avec des nombres en pixels.",gridHeightInPercentageNotSupported:"La fixation de colonne n\xe9cessite une configuration diff\xe9rente. La hauteur de la grille doit \xeatre r\xe9gl\xe9e en pixels.",defaultColumnWidthInPercentageNotSupported:"La largeur de colonne par d\xe9faut en pourcentage n'est pas prise en charge lors de l'utilisation de ColumnFixing",columnsWidthShouldBeSetInPixels:"ColumnFixing requiert un param\xe8tre de largeur de colonne diff\xe9rent. La largeur de colonne avec la cl\xe9 {key} doit \xeatre d\xe9finie avec un nombre de pixels.",unboundColumnsNotSupported:"ColumnFixing n'est pas pris en charge avec les colonnes ind\xe9pendantes",excelNavigationNotSupportedWithCurrentEditMode:"Le mode de navigation Excel est pris en charge uniquement pour les modes Modification cellule et Modification ligne. Pour pr\xe9venir cette erreur, d\xe9sactivez excelNavigationMode ou bien d\xe9finissez editMode sur cellule ou ligne.",initialFixingNotApplied:"Le verrouillage initial n'a pas pu \xeatre appliqu\xe9 sur les colonnes avec la cl\xe9\xa0: {0}. Raison\xa0: {1}",setOptionGridWidthException:"Valeur incorrecte pour la largeur de grille facultative. Avec des colonnes fixes, la largeur de la zone visible de la ou des colonnes non fixes doit \xeatre sup\xe9rieure ou \xe9gale \xe0 la valeur de minimalVisibleAreaWidth.",noneError:"Aucune erreur",notValidIdentifierError:"Il n'existe aucune colonne avec l'identifiant sp\xe9cifi\xe9",fixingRefusedError:"Verrouillage refus\xe9 car il existe UNIQUEMENT une colonne non verrouill\xe9e visible",fixingRefusedMinVisibleAreaWidthError:"Le verrouillage de colonne n'est pas autoris\xe9, en raison de la largeur minimale de la zone visible des colonnes non verrouill\xe9es",alreadyHiddenError:"Vous essayez de verrouiller/d\xe9verrouiller une colonne masqu\xe9e",alreadyUnfixedError:"La colonne que vous essayez de d\xe9verrouiller est d\xe9j\xe0 d\xe9verrouill\xe9e",alreadyFixedError:"La colonne que vous essayez de verrouiller est d\xe9j\xe0 verrouill\xe9e",unfixingRefusedError:"Le d\xe9verrouillage est refus\xe9 car il n'existe qu'une seule colonne verrouill\xe9e visible et car il existe au moins une colonne verrouill\xe9e masqu\xe9e.",targetNotFoundError:"La colonne cible avec la cl\xe9 {key} n\u2019a pas pu \xeatre trouv\xe9e. V\xe9rifiez la cl\xe9 utilis\xe9e pour la recherche et modifiez-la si n\xe9cessaire."};$.ig.GridAppendRowsOnDemand=$.ig.GridAppendRowsOnDemand||{};$.ig.locale.fr.GridAppendRowsOnDemand={optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",loadMoreDataButtonText:"Charger d'autres donn\xe9es",appendRowsOnDemandRequiresHeight:"La fonction AppendRowsOnDemand requiert une hauteur",groupByNotSupported:"igGridGroupBy n'est pas pris en charge avec AppendRowsOnDemand",pagingNotSupported:"igGridPaging n'est pas pris en charge avec AppendRowsOnDemand",cellMergingNotSupported:"igGridCellMerging n'est pas pris en charge avec AppendRowsOnDemand",virtualizationNotSupported:"La virtualisation n'est pas prise en charge avec AppendRowsOnDemand"};$.ig.igGridResponsive=$.ig.igGridResponsive||{};$.ig.locale.fr.igGridResponsive={optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",fixedVirualizationNotSupported:"igGridResponsive n'est pas pris en charge avec la virtualisation verrouill\xe9e"};$.ig.igGridMultiColumnHeaders=$.ig.igGridMultiColumnHeaders||{};$.ig.locale.fr.igGridMultiColumnHeaders={optionChangeNotSupported:"{optionName} ne peut pas \xeatre modifi\xe9 apr\xe8s l\u2019initialisation. Ses valeurs doivent \xeatre d\xe9finies pendant l\u2019initialisation.",multiColumnHeadersNotSupportedWithColumnVirtualization:"La fonction d'en-t\xeates de colonnes multiples n'est pas prise en charge avec columnVirtualization",atLeastOneColumnShouldBeShownWhenCollapseOrExpand:"Au moins un colonne doit \xeatre affich\xe9e lorsque vous agrandissez ou r\xe9duisez l\u2019en-t\xeate de colonnes multiples.",collapsedColumnIconTooltip:"D\xe9velopper",expandedColumnIconTooltip:"R\xe9duire"};$.ig.Grid.locale=$.ig.Grid.locale||$.ig.locale.fr.Grid;$.ig.GridFeatureChooser.locale=$.ig.GridFeatureChooser.locale||$.ig.locale.fr.GridFeatureChooser;$.ig.GridFiltering.locale=$.ig.GridFiltering.locale||$.ig.locale.fr.GridFiltering;$.ig.GridGroupBy.locale=$.ig.GridGroupBy.locale||$.ig.locale.fr.GridGroupBy;$.ig.GridHiding.locale=$.ig.GridHiding.locale||$.ig.locale.fr.GridHiding;$.ig.GridResizing.locale=$.ig.GridResizing.locale||$.ig.locale.fr.GridResizing;$.ig.GridPaging.locale=$.ig.GridPaging.locale||$.ig.locale.fr.GridPaging;$.ig.GridSelection.locale=$.ig.GridSelection.locale||$.ig.locale.fr.GridSelection;$.ig.GridRowSelectors.locale=$.ig.GridRowSelectors.locale||$.ig.locale.fr.GridRowSelectors;$.ig.GridSorting.locale=$.ig.GridSorting.locale||$.ig.locale.fr.GridSorting;$.ig.GridSummaries.locale=$.ig.GridSummaries.locale||$.ig.locale.fr.GridSummaries;$.ig.GridUpdating.locale=$.ig.GridUpdating.locale||$.ig.locale.fr.GridUpdating;$.ig.CellMerging.locale=$.ig.CellMerging.locale||$.ig.locale.fr.CellMerging;$.ig.ColumnMoving.locale=$.ig.ColumnMoving.locale||$.ig.locale.fr.ColumnMoving;$.ig.ColumnFixing.locale=$.ig.ColumnFixing.locale||$.ig.locale.fr.ColumnFixing;$.ig.GridAppendRowsOnDemand.locale=$.ig.GridAppendRowsOnDemand.locale||$.ig.locale.fr.GridAppendRowsOnDemand;$.ig.igGridResponsive.locale=$.ig.igGridResponsive.locale||$.ig.locale.fr.igGridResponsive;$.ig.igGridMultiColumnHeaders.locale=$.ig.igGridMultiColumnHeaders.locale||$.ig.locale.fr.igGridMultiColumnHeaders;$.ig.HierarchicalGrid.locale=$.ig.HierarchicalGrid.locale||$.ig.locale.fr.HierarchicalGrid;return $.ig.locale.fr});