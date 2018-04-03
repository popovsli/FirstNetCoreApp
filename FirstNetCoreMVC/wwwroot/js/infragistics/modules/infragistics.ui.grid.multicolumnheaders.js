/*!@license
 * Infragistics.Web.ClientUI Grid Multi Headers 17.2.456
 *
 * Copyright (c) 2011-2017 Infragistics Inc.
 *
 * http://www.infragistics.com/
 *
 * Depends on:
 *	jquery-1.9.1.js
 *	jquery.ui.core.js
 *	jquery.ui.widget.js
 *	infragistics.ui.grid.framework.js
 *	infragistics.ui.shared.js
 *	infragistics.dataSource.js
 *	infragistics.util.js
 */
(function(factory){if(typeof define==="function"&&define.amd){define(["./infragistics.ui.grid.framework"],factory)}else{return factory(jQuery)}})(function($){$.widget("ui.igGridMultiColumnHeaders",$.ui.igWidget,{localeWidgetName:"igGridMultiColumnHeaders",css:{multiHeaderCell:"ui-iggrid-multiheader-cell",expandedHeaderIndicator:"ui-iggrid-multiheader-expanded",collapsedHeaderIndicator:"ui-iggrid-multiheader-collapsed",collapsibleIndicatorContainer:"ui-iggrid-indicatorcontainer ui-iggrid-collapsibleindicatorcontainer"},options:{inherit:false},events:{groupCollapsing:"groupCollapsing",groupCollapsed:"groupCollapsed",groupExpanding:"groupExpanding",groupExpanded:"groupExpanded"},_createWidget:function(){$.Widget.prototype._createWidget.apply(this,arguments)},changeLocale:function(){var self=this;this.grid.container().find("[data-expanded-state]").each(function(){self._changeLocaleForElement($(this))})},_registerWidget:$.noop,_unregisterWidget:$.noop,_renderingMultiColumnHeader:function(){this._renderHeaderColumns(this.grid._headerParent);this.grid._trigger(this.grid.events.headerRendered,null,{owner:this.grid,table:this.grid.headersTable()});this.grid._headerRenderCancel=false},_analyzeRowspanRows:function(oldCols,level){var i,col,groups=[],ml=this.grid._maxLevel-level,rowspan;for(i=0;i<oldCols.length;i++){rowspan=1;col=oldCols[i];col.rowspan=col.rowspan||col.rowSpan;if($.type(col.rowspan)==="string"){col.rowspan=parseInt(col.rowspan,10)}if(col.rowspan>0){rowspan=col.rowspan}if(col.group!==undefined&&col.group!==null){groups.push({group:col.group,level:level+rowspan})}else{if(col.level===0){if(col.rowspan===null||col.rowspan===undefined||isNaN(col.rowspan)){if(ml+1-col.level>0){col.rowspan=ml+1-col.level}}}}if(this._rows[ml]===undefined||this._rows[ml]===null){this._rows[ml]=[]}this._rows[ml].push(col)}for(i=0;i<groups.length;i++){this._analyzeRowspanRows(groups[i].group,groups[i].level)}},_renderRow:function(headerContainer,row,level){var col,i,$headerCell,$tr=$('<tr data-mch-level="'+level+'" role="row"></tr>').appendTo(headerContainer);for(i=0;i<row.length;i++){col=row[i];$headerCell=this._createHeaderColumnMarkup(col);$headerCell.appendTo($tr)}},_renderHeaderColumns:function($container){var $th,i,j,k,oldCols,parents,key,headersTable,parentCol,mchElement,$col,cols=this.grid.options.columns,mchChildren,isToHide,colsLength=cols.length,initHiddenCols=this.grid._initialHiddenColumns,gridId=this.grid.id(),$thead;this._arrayTargetRowspan=[];this._totalColumnsLength=$container.find("colgroup col").length;$thead=$container.find("thead");if($thead.length>0){$container=$thead.empty().attr("role","rowgroup")}else{$container=$('<thead role="rowgroup"></thead>').appendTo($container)}this._tr={};oldCols=this.grid._oldCols;this._rows={};this._analyzeRowspanRows(oldCols,0);for(i=this.grid._maxLevel;i>=0;i--){if(this._rows[i]!==null&&this._rows[i]!==undefined){this._renderRow($container,this._rows[i],i)}}for(i=0;i<colsLength;i++){$th=this.grid.container().find("#"+gridId+"_"+cols[i].key).data("columnIndex",i);$th.data("data-mch-order",i);this.grid._headerCells.push($th)}if(initHiddenCols){headersTable=this.grid.headersTable().find("thead");for(i=0;i<initHiddenCols.length;i++){key=initHiddenCols[i].key;this.grid.container().find("#"+gridId+"_"+key).css("display","none");$col=this.grid.headersTable().find(">colgroup>col").eq(this.grid.getVisibleIndexByKey(key,true));$col.remove();parents=this.grid._getParentsMultiHeader(key);for(j=0;j<parents.length;j++){parentCol=parents[j];if(parentCol.level>0){mchElement=this.grid._getMultiHeaderColumnById(parentCol.identifier);if(mchElement&&mchElement.children){mchChildren=mchElement.children;isToHide=true;if(mchElement.hidden!==true){for(k=0;k<mchChildren.length;k++){if(mchChildren[k].level===0){$th=this.grid.container().find("#"+gridId+"_"+mchChildren[k].key)}else{$th=headersTable.find("th[data-mch-id="+mchChildren[k].identifier+"]")}if(!$th.is(":visible")){isToHide=false;break}}}if(isToHide){headersTable.find("th[data-mch-id="+parentCol.identifier+"]").css("display","none")}}}}}}},_createHeaderColumnMarkup:function(col){var grid=this.grid,id,isMultiColumnHeader=true,headerClass=grid.css.headerClass,customClass=col.headerCssClass||"",$th=$("<th></th>"),$headerCell,childIds="",i,length;if(col.group){length=col.group.length;for(i=0;i<length;i++){childIds+=this.grid.element[0].id+"_"+col.group[i].key+(i===length-1?"":" ")}}else if(col.headerText===undefined){col.headerText=col.key}this._renderCollapsibleHeaderIndicator($th,col);$headerCell=$th.append('<span class="'+grid.css.headerTextClass+'">'+col.headerText+"</span>").attr({role:"columnheader","aria-label":col.headerText,tabIndex:grid.options.tabIndex}).addClass(headerClass).addClass(customClass);if(col.colspan>1){$th.attr("colspan",col.colspan)}if(col.rowspan>1){$headerCell.attr("rowspan",col.rowspan)}if(col.key){$headerCell.attr("id",this.grid.element[0].id+"_"+col.key)}if(col.level===0){id=col.key;isMultiColumnHeader=false;$headerCell.attr("data-isheadercell",true)}else{id=col.identifier;$headerCell.addClass(this.css.multiHeaderCell);$headerCell.attr("data-mch-id",col.identifier);if(childIds){$headerCell.attr("aria-owns",childIds)}}grid._trigger(grid.events.headerCellRendered,null,{owner:grid,th:$headerCell,columnKey:id,isMultiColumnHeader:isMultiColumnHeader});return $headerCell},_renderCollapsibleHeaderIndicator:function($th,col){var $container,$anchor,$button,self=this,shouldExpand=false,title;if(col&&col.groupOptions&&col.groupOptions.allowGroupCollapsing===true){shouldExpand=col.groupOptions.expanded===true;$container=$("<div></div>").addClass(self.css.collapsibleIndicatorContainer);title=shouldExpand?this._getLocaleValue("expandedColumnIconTooltip"):this._getLocaleValue("collapsedColumnIconTooltip");$anchor=$("<a></a>").attr("href","#").attr({title:title,"data-expanded-state":shouldExpand,"data-localeid":shouldExpand?"expandedColumnIconTooltip":"collapsedColumnIconTooltip","data-localeattr":"title"}).attr("tabindex",0).on({keydown:function(event){if(event.keyCode===$.ui.keyCode.ENTER||event.keyCode===$.ui.keyCode.SPACE){self._headerIndicatorClick(event)}}}).appendTo($container);$button=$("<span></span>").addClass(shouldExpand?this.css.expandedHeaderIndicator:this.css.collapsedHeaderIndicator).on({click:this._headerIndicatorClickHandler}).appendTo($anchor);$container.appendTo($th)}},expandGroup:function(groupKey,callback){this._setExpanded(groupKey,true,null,false,callback)},collapseGroup:function(groupKey,callback){this._setExpanded(groupKey,false,null,false,callback)},toggleGroup:function(groupKey,callback){this._setExpanded(groupKey,null,null,false,callback)},_setToggleButtonTooltip:function($button,expanded){var localeId=expanded?"expandedColumnIconTooltip":"collapsedColumnIconTooltip";$button.attr({title:this._getLocaleValue(localeId),"data-localeid":localeId,"data-expanded-state":expanded})},_setExpanded:function(groupKey,expanded,event,throwEvents,callback){var self=this,i,column,isExpanded,th,headerRows=self.grid.headersTable().find("thead > tr"),groupColumnsLength,noCancel;column=self.grid._getMultiHeaderColumnById(groupKey);if(!column||!column.groupOptions||column.groupOptions.allowGroupCollapsing===false||!column.group){return}isExpanded=column.groupOptions.expanded===true;if(isExpanded===expanded){return}if(expanded!==true&&expanded!==false){expanded=!isExpanded}th=headerRows.find("th[data-mch-id="+groupKey+"]");if(throwEvents===true){noCancel=self._trigger(expanded?self.events.groupExpanding:self.events.groupCollapsing,event,{owner:self,column:column,element:th});if(noCancel===false){return}}groupColumnsLength=column.group.length;self.grid._loadingIndicator.show();setTimeout(function(){column.groupOptions.expanded=!column.groupOptions.expanded;for(i=0;i<groupColumnsLength;i++){self._refreshMultiColumnHierarchyVisibility(column.group[i],column)}if(column.groupOptions.expanded){th.find("."+self.css.collapsedHeaderIndicator).removeClass(self.css.collapsedHeaderIndicator).addClass(self.css.expandedHeaderIndicator);self._setToggleButtonTooltip(th.find("[data-expanded-state]"),true)}else{th.find("."+self.css.expandedHeaderIndicator).removeClass(self.css.expandedHeaderIndicator).addClass(self.css.collapsedHeaderIndicator);self._setToggleButtonTooltip(th.find("[data-expanded-state]"),false)}if(throwEvents===true){self._trigger(column.groupOptions.expanded?self.events.groupExpanded:self.events.groupCollapsed,event,{owner:self,column:column,element:th})}self.grid._loadingIndicator.hide();if(callback){$.ig.util.invokeCallback(callback)}},0)},_headerIndicatorClick:function(event){var target=$(event.target),columnId=target.closest("th").attr("data-mch-id");this._setExpanded(columnId,null,event,true);event.preventDefault();event.stopPropagation()},_refreshMultiColumnHierarchyVisibility:function(col,parentCol){var i,parentAlowsGroupCollapsing=false,parentColExpanded=false,shouldHide=false;if(parentCol){parentAlowsGroupCollapsing=parentCol.groupOptions&&parentCol.groupOptions.allowGroupCollapsing===true;if(parentCol.groupOptions&&parentCol.groupOptions.expanded===false){parentColExpanded=false}else{parentColExpanded=true}}shouldHide=col.groupOptions&&(parentColExpanded===true&&(col.groupOptions.hidden==="always"||col.groupOptions.hidden==="parentexpanded")||parentColExpanded===false&&(col.groupOptions.hidden==="always"||col.groupOptions.hidden==="parentcollapsed"));if(parentCol&&parentAlowsGroupCollapsing&&shouldHide){if(col.group){for(i=0;i<col.children.length;i++){this.grid._setHidden(col.children[i].key,true)}}else{this.grid._setHidden(col.key,true)}}else{if(col.group){for(i=0;i<col.group.length;i++){this._refreshMultiColumnHierarchyVisibility(col.group[i],col)}}else{if(parentAlowsGroupCollapsing){this.grid._setHidden(col.key,false)}}}},_validateGroup:function(col){var i,colsCountWhenExpanded,colsCountWhenCollapsed;if(!col.group){return}if(col.groupOptions&&col.groupOptions.allowGroupCollapsing===true){colsCountWhenExpanded=colsCountWhenCollapsed=0;for(i=0;i<col.group.length;i++){if(!col.group[i].groupOptions||col.group[i].groupOptions.hidden!=="always"&&col.group[i].groupOptions.hidden!=="parentexpanded"){colsCountWhenExpanded++}if(!col.group[i].groupOptions||col.group[i].groupOptions.hidden!=="always"&&col.group[i].groupOptions.hidden!=="parentcollapsed"){colsCountWhenCollapsed++}}if(colsCountWhenCollapsed===0||colsCountWhenExpanded===0){throw new Error(this._getLocaleValue("atLeastOneColumnShouldBeShownWhenCollapseOrExpand"))}}for(i=0;i<col.group.length;i++){this._validateGroup(col.group[i],col)}},_gridRendered:function(){var i;if(!this.grid._oldCols){return}for(i=0;i<this.grid._oldCols.length;i++){this._validateGroup(this.grid._oldCols[i])}for(i=0;i<this.grid._oldCols.length;i++){this._refreshMultiColumnHierarchyVisibility(this.grid._oldCols[i],null)}},getMultiColumnHeaders:function(){return this.grid._oldCols},_createHandlers:function(){this._headerIndicatorClickHandler=$.proxy(this._headerIndicatorClick,this);this._gridRenderedHandler=$.proxy(this._gridRendered,this)},_detachEvents:function(){if(this._gridRenderedHandler!==null&&this._gridRenderedHandler!==undefined){this.grid.element.unbind("iggridrendered",this._gridRenderedHandler)}},_injectGrid:function(gridInstance){this.grid=gridInstance;this._createHandlers();this._detachEvents();this.grid.element.bind("iggridrendered",this._gridRenderedHandler);if(this.grid.options.virtualizationMode!=="continuous"&&(this.grid.options.virtualization===true&&this.grid.options.width||this.grid.options.columnVirtualization===true)){throw new Error(this._getLocaleValue("multiColumnHeadersNotSupportedWithColumnVirtualization"))}},destroy:function(){var collapsibleHeaderIcons=this.grid.headersTable().find("div."+this.css.collapsibleIndicatorContainer.split(" ").join("."));this._detachEvents();if(collapsibleHeaderIcons.length>0){collapsibleHeaderIcons.find("> a").off("keydown").find("> span").off("click");collapsibleHeaderIcons.remove()}this._superApply(arguments);return this}});$.extend($.ui.igGridMultiColumnHeaders,{version:"17.2.456"});return $});(function(factory){if(typeof define==="function"&&define.amd){define("watermark",["jquery"],factory)}else{factory(jQuery)}})(function($){$(document).ready(function(){var wm=$("#__ig_wm__").length>0?$("#__ig_wm__"):$("<div id='__ig_wm__'></div>").appendTo(document.body);wm.css({position:"fixed",bottom:0,right:0,zIndex:1e3}).addClass("ui-igtrialwatermark")})});