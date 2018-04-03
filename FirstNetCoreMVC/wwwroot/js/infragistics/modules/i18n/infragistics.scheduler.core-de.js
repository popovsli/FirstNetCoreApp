/*!@license
* Infragistics.Web.ClientUI infragistics.scheduler.core.js resources 17.2.20172.93
*
* Copyright (c) 2011-2017 Infragistics Inc.
*
* http://www.infragistics.com/
*
*/
(function(factory){if(typeof define==="function"&&define.amd){define([],factory)}else{factory()}})(function(){$=$||{};$.ig=$.ig||{};$.ig.locale=$.ig.locale||{};$.ig.locale.de=$.ig.locale.de||{};$.ig.locale.de.schedulerCore=$.ig.locale.de.schedulerCore||{};var l=$.ig.locale.de.schedulerCore;l["ActivityBase_Exception_CannotModifyOccurrenceProperty"]="The value of the {0} property cannot be modified on this {1} instance because it is a member of a recurrence.";l["LE_ActivityBase_DisassociatedResource"]="The specified resource is not associated with the same data source as this activity.";l["LE_AppointmentItemsSource_CannotEdit"]="The appointment item source does not support modification of its contents.";l["LE_AppointmentItemsSource_InvalidValue_JS"]="The specified value must be a JSON array or an $.ig.DataSource instance.";l["LE_AppointmentItemsSource_NoIList_DOTNET"]="The AppointmentItemsSource does not support modification of its contents. The item source must implement System.Collections.IList in order to support modifications.";l["LE_AppointmentPropertyMapping_RecurrenceRoot"]="The RecurrenceRoot property is not bindable and cannot be mapped. Create a mapping for the RecurrenceId property instead.";l["LE_AppointmentPropertyMapping_Resource"]="The Resource property is not bindable and cannot be mapped. Create a mapping for the ResourceId property instead.";l["LE_BeginEdit_CreatePending"]="The specified activity cannot be edited because there is a 'Create' operation pending.";l["LE_CannotCreateDataObject_DOTNET"]="Could not create new data object instance. Ensure that your data object type has a parameterless constructor. If it does not, assign a delegate to the CreateAppointmentDataObjectCallback property which creates new instances of this type.";l["LE_CannotModifyApppointmentsWhenDataSourceSet"]="Operation is not valid while DataSource is in use. Access and modify elements with Scheduler.DataSource instead.";l["LE_CannotSetDataSourceWhenAppointmentsAreDefined"]="Appointments collection must be empty before using DataSource.";l["LE_CouldNotConvertColorScheme"]="The value '{0}' could not be converted to a ScheduleResourceColorScheme value.";l["LE_CouldNotConvertValue"]="The value '{0}' could not be converted to type {1}.";l["LE_CreateDataObjectFailed"]="Could not create new data object instance.";l["LE_DataObjectNotAssociated"]="The specified data object is not associated with an Appointment.";l["LE_DuplicateIdentifier"]="The identifier '{0}' is already in use. Activity/Resource identifiers must be unique.";l["LE_EndEdit_DataObjectAlreadyAssociated"]="This data object is already associated with an activity.";l["LE_EndEdit_NotInEditMode"]="EndEdit cannot be called on the specified activity because it is not in edit mode. BeginEdit must be called first before an activity edit operation can be committed.";l["LE_InvalidDayOfWeekRule"]="The specified day of week rule is invalid.";l["LE_MissingIdentifier"]="Missing identifier.";l["LE_NoAppointmentItemsSource"]="The AppointmentItemsSource has not been assigned.";l["LE_NoCreateAppointmentDataObjectCallback_JS"]="A new data object instance could not be created. You must specify a value for the CreateAppointmentDataObjectCallback property.";l["LE_NoDataObject"]="The specified activity's underlying data object does not exist in the item source.";l["LE_NoPropertyMapping_Appointment"]="No property mapping exists for Appointment property '{0}'.";l["LE_RecurrenceParsing"]="Error parsing recurrence, context: {0}";l["LE_RecurrenceSerializing"]="Error serializing recurrence, context: {0}";l["LE_SchedulePropertyMap_Missing"]="The following required property mappings were not defined:";l["LE_SchedulePropertyMap_NoPropertyFound"]="No public property named '{0}' was found on the underlying data object.";l["LIT_AgendaDayHeader_Today"]="Today";l["LIT_AgendaNoEventsMessage"]="No Events";l["LIT_AgendaStartTime_AllDay"]="all-day";l["LIT_AgendaStartTime_Ends"]="Ends";l["RD_And"]="und";l["RD_AtTime"]="um {0}";l["RD_Effective1"]="ab dem {0}";l["RD_Effective2"]="vom {0} bis zum {1}";l["RD_Effective3"]="ab dem {0} von {1} bis {2}";l["RD_Effective4"]="ab dem {0} um {1}";l["RD_Effective5"]="ab dem {0} bis zum {1} um {2}";l["RD_Effective6"]="ab dem {0} bis zum {1} von {2} bis {3}";l["RD_Every"]="alle {0} {1}";l["RD_FrequencyLiterals"]="Jahr,Monat,Woche,Tag,Stunde,Minute,Sekunde";l["RD_FrequencyLiterals2"]="j\xe4hrlich,monatlich,w\xf6chentlich,t\xe4glich,st\xfcndlich,min\xfctlich,sek\xfcndlich";l["RD_FrequencyLiteralsPlural"]="Jahre,Monate,Wochen,Tage,Stunden,Minuten,Sekunden";l["RD_InMonth"]="im {0}";l["RD_Last"]="letzten";l["RD_NumberSuffix_nd"]=".";l["RD_NumberSuffix_rd"]=".";l["RD_NumberSuffix_st"]=".";l["RD_NumberSuffix_th"]=".";l["RD_OccurrenceOfThe"]="Serienelement am";l["RD_OfEveryMinuteOrHour"]="von jeder {0}";l["RD_OfTheMonthOrYear"]="";l["RD_OfTheNthMinuteOrHour"]="der {0} {1}";l["RD_OnEach"]="jeden";l["RD_OnEverySecond"]="jede Sekunde";l["RD_OnThe"]="am";l["RD_OnTheNthSecond"]="in der {0} Sekunde";l["RD_Or"]="oder";l["RD_OrdinalDayOfMonthUsesSuffix"]="true";l["RD_OrdinalNumberWithSuffix"]="{0}{1}";l["RD_RecurrenceDescriptionOverallStructure"]="Erfolgt {0}{1}{2}";l["RD_RepeatingMultipleTimes"]="wird {0} Mal wiederholt";l["RD_RepeatingOneTime"]="wird einmal wiederholt";l["RD_RulesInMonth"]="{0} {1}";l["RD_ToTheLast"]="bis zum letzten";l["RD_Weekday"]="Wochentag";l["RD_WeekendDay"]="Wochenendtag";l["RD_WeekOrDayOfTheMonthOrYear"]="{0} {1}";l["ScheduleDayOfWeekSettings_Exception_InvalidValue"]="Der Wert '{0}' konnte nicht erfolgreich analysiert werden.";l["WorkingHourTimeRange_Exception_CannotModifyTime"]="Die {0}-Eigenschaft kann nicht ge\xe4ndert werden, weil diese Instanz bereits der Arbeitsstunden-Sammlung hinzugef\xfcgt wurde.";$.ig.schedulerCore=$.ig.schedulerCore||{};$.ig.schedulerCore.locale=$.ig.schedulerCore.locale||l;return l});