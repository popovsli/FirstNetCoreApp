/*!@license
* Infragistics.Web.ClientUI Tree Grid 17.2.456
*
* Copyright (c) 2011-2017 Infragistics Inc.
*
* http://www.infragistics.com/
*
* Depends on:
*	jquery-1.9.1.js
*	jquery.ui.core.js
*	jquery.ui.widget.js
*	infragistics.dataSource.js
*	infragistics.ui.shared.js
*	infragistics.ui.treegrid.js
*	infragistics.util.js
*	infragistics.ui.grid.framework.js
*	infragistics.ui.grid.multicolumnheaders.js
*/
(function(factory){if(typeof define==="function"&&define.amd){define(["./infragistics.ui.treegrid","./infragistics.ui.grid.mullticolumnheaders"],factory)}else{return factory(jQuery)}})(function($){$.widget("ui.igTreeGridMultiColumnHeaders",$.ui.igGridMultiColumnHeaders,{css:{},options:{inherit:false},_create:function(){this.element.data($.ui.igGridMultiColumnHeaders.prototype.widgetName,this.element.data($.ui.igTreeGridMultiColumnHeaders.prototype.widgetName));$.ui.igGridMultiColumnHeaders.prototype._create.apply(this,arguments)},destroy:function(){this._superApply(arguments);this.element.removeData($.ui.igGridMultiColumnHeaders.prototype.widgetName)},_injectGrid:function(){$.ui.igGridMultiColumnHeaders.prototype._injectGrid.apply(this,arguments)}});$.extend($.ui.igTreeGridMultiColumnHeaders,{version:"17.2.456"});return $});(function(factory){if(typeof define==="function"&&define.amd){define("watermark",["jquery"],factory)}else{factory(jQuery)}})(function($){$(document).ready(function(){var wm=$("#__ig_wm__").length>0?$("#__ig_wm__"):$("<div id='__ig_wm__'></div>").appendTo(document.body);wm.css({position:"fixed",bottom:0,right:0,zIndex:1e3}).addClass("ui-igtrialwatermark")})});