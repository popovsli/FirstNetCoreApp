(function(factory){if(typeof define==="function"&&define.amd){define(["jquery"],factory)}else{factory(jQuery)}})(function($){$.ig=$.ig||{};$.ig.regional=$.ig.regional||{};if($.datepicker&&$.datepicker.regional){$.datepicker.regional["ro"]={closeText:"\xcenchide",prevText:"&#xAB; Luna precedent\u0103",nextText:"Luna urm\u0103toare &#xBB;",currentText:"Azi",monthNames:["Ianuarie","Februarie","Martie","Aprilie","Mai","Iunie","Iulie","August","Septembrie","Octombrie","Noiembrie","Decembrie"],monthNamesShort:["Ian","Feb","Mar","Apr","Mai","Iun","Iul","Aug","Sep","Oct","Nov","Dec"],dayNames:["Duminic\u0103","Luni","Mar\u0163i","Miercuri","Joi","Vineri","S\xe2mb\u0103t\u0103"],dayNamesShort:["Dum","Lun","Mar","Mie","Joi","Vin","S\xe2m"],dayNamesMin:["Du","Lu","Ma","Mi","Jo","Vi","S\xe2"],weekHeader:"S\u0103pt",dateFormat:"dd.mm.yy",firstDay:1,isRTL:false,showMonthAfterYear:false,yearSuffix:""}}$.ig.regional.ro={monthNames:["Ianuarie","Februarie","Martie","Aprilie","Mai","Iunie","Iulie","August","Septembrie","Octombrie","Noiembrie","Decembrie"],monthNamesShort:["Ian","Feb","Mar","Apr","Mai","Iun","Iul","Aug","Sep","Oct","Nov","Dec"],dayNames:["Duminic\u0103","Luni","Mar\u0163i","Miercuri","Joi","Vineri","S\xe2mb\u0103t\u0103"],dayNamesShort:["Dum","Lun","Mar","Mie","Joi","Vin","S\xe2m"],datePattern:"dd.MM.yyyy",dateLongPattern:"d MMMM yyyy",dateTimePattern:"dd.MM.yyyy HH:mm",timePattern:"HH:mm",timeLongPattern:"HH:mm:ss",dateTitleFullPattern:"dd MM yy",dateTitleMonthPattern:"MM yy",numericNegativePattern:"-n$",numericDecimalSeparator:",",numericGroupSeparator:".",numericMaxDecimals:2,currencyPositivePattern:"n $",currencyNegativePattern:"-n $",currencySymbol:"lei",currencyDecimalSeparator:",",currencyGroupSeparator:".",percentDecimalSeparator:",",percentGroupSeparator:"."};if($.ig.util&&$.ig.util.changeGlobalRegional){$.ig.util.changeGlobalRegional("ro")}});