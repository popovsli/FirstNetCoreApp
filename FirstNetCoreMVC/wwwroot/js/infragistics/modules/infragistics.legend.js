/*!@license
* Infragistics.Web.ClientUI infragistics.legend.js 17.2.20172.93
*
* Copyright (c) 2011-2017 Infragistics Inc.
*
* http://www.infragistics.com/
*
* Depends:
*     jquery-1.4.4.js
*     jquery.ui.core.js
*     jquery.ui.widget.js
*     infragistics.util.js
*     infragistics.ext_core.js
*     infragistics.ext_collections.js
*     infragistics.dv_core.js
*     infragistics.dv_visualdata.js
*     infragistics.ext_ui.js
*/
(function(factory){if(typeof define==="function"&&define.amd){define(["./infragistics.util","./infragistics.ext_core","./infragistics.ext_collections","./infragistics.dv_core","./infragistics.dv_visualdata","./infragistics.ext_ui"],factory)}else{factory(igRoot)}})(function($){$.ig=$.ig||{};var $$t={};$.ig.globalDefs=$.ig.globalDefs||{};$.ig.globalDefs.$$p=$$t;$$0=$.ig.globalDefs.$$0;$$4=$.ig.globalDefs.$$4;$$1=$.ig.globalDefs.$$1;$$w=$.ig.globalDefs.$$w;$$ap=$.ig.globalDefs.$$ap;$$6=$.ig.globalDefs.$$6;$$a=$.ig.globalDefs.$$a;$.ig.$currDefinitions=$$t;$.ig.util.bulkDefine(["LegendBaseViewManager:a","LegendMouseEventHandler:c","LegendMouseButtonEventHandler:e","ItemLegend:f","Legend:g","LegendBase:i","ScaleLegend:j","ItemLegendView:k","LegendBaseView:l","LegendView:m","ScaleLegendView:n"]);var $a=$.ig.intDivide,$b=$.ig.util.cast,$c=$.ig.util.defType,$d=$.ig.util.defEnum,$e=$.ig.util.getBoxIfEnum,$f=$.ig.util.getDefaultValue,$g=$.ig.util.getEnumValue,$h=$.ig.util.getValue,$i=$.ig.util.intSToU,$j=$.ig.util.nullableEquals,$k=$.ig.util.nullableIsNull,$l=$.ig.util.nullableNotEquals,$m=$.ig.util.toNullable,$n=$.ig.util.toString$1,$o=$.ig.util.u32BitwiseAnd,$p=$.ig.util.u32BitwiseOr,$q=$.ig.util.u32BitwiseXor,$r=$.ig.util.u32LS,$s=$.ig.util.unwrapNullable,$t=$.ig.util.wrapNullable,$u=String.fromCharCode,$v=$.ig.util.castObjTo$t,$w=$.ig.util.compareSimple,$x=$.ig.util.tryParseNumber,$y=$.ig.util.tryParseNumber1,$z=$.ig.util.numberToString,$0=$.ig.util.numberToString1,$1=$.ig.util.parseNumber,$2=$.ig.util.compare,$3=$.ig.util.replace,$4=$.ig.util.stringFormat,$5=$.ig.util.stringFormat1,$6=$.ig.util.stringFormat2,$7=$.ig.util.stringCompare1,$8=$.ig.util.stringCompare2,$9=$.ig.util.stringCompare3;$c("LegendBaseViewManager:a","Object",{a:null,init:function(a){this.g=null;this.d=false;$.ig.$op.init.call(this);this.a=a;this._f=new $$4.g($.ig.$op.$type,$$1.$b.$type,0);this.n()},g:null,n:function(){var $self=this;if(this.g==null){this.g=function(a,b){var c=$.ig.LegendItemHelper.prototype.b();if(window.devicePixelRatio!=window.undefined&&($.ig.util.isNaN(c)||window.devicePixelRatio!=c)){$.ig.LegendItemHelper.prototype.b(window.devicePixelRatio);$self.a.y()}};window.addEventListener("resize",this.g,false)}this.g(this,null)},q:function(a){if(a==null){if(this.g!=null){window.removeEventListener("resize",this.g,false);this.g=null}this._j=null;this._h=null;return}this._h=a;this._j=this._h.createElement("table");this._j.addClass(this.a._j);this._h.append(this._j)},_j:null,_h:null,d:false,i:function(a,b){var c=$b($$a.$g.$type,a);var d=this._h.createElement("tr");d.addClass(this.a._k);if(c!=null){var e=$b($.ig.ILegendContext.prototype.$type,c.content());if(e!=null&&c._ah!=null){var f=new $$a.l;f.context=d;f.passID="LegendItem";var g=new $$a.m;g.passInfo=f;g.width=NaN;g.height=NaN;g.data=e;g.context=d;var h=new $$a.n;h.passInfo=f;if(c._ah.measure()!=null){c._ah.measure()(g)}h.context=this._h.getSubRenderer(d);h.availableWidth=g.width;h.availableHeight=g.height;h.data=e;h.xPosition=0;h.yPosition=0;c._ah.render()(h);var i=d.findByClass(".ui-legend-item-badge");for(var j=0;j<i.length;j++){i[j].removeClass("ui-legend-item-badge").addClass(this.a._i)}i=d.findByClass(".ui-legend-item-text");for(var k=0;k<i.length;k++){i[k].removeClass("ui-legend-item-text").addClass(this.a._l)}}}return d},_f:null,m:function(a,b){var c=this.i(a,this._j);c.listen("mouseup",this.a.t.runOn(this.a));c.listen("mousedown",this.a.q.runOn(this.a));c.listen("mouseleave",this.a.r.runOn(this.a));c.listen("mousemove",this.a.s.runOn(this.a));this._f.add(a,c);if(this._j.getChildCount()==0||b>=this._j.getChildCount()){this._j.append(c)}else{var d=this._j.getChildAt(b);d.before(c)}},r:function(a){},s:function(a){var $self=this;var b;if(function(){var c=$self._f.tryGetValue(a,b);b=c.p1;return c.ret}()){b.unlistenAll();b.remove();this._f.remove(a)}},l:function(visual_){var a=this._f.getEnumerator();while(a.moveNext()){var pair_=a.current();if(pair_.value().getNativeElement()===visual_){return pair_.key()}}return null},e:function(a){var c=this._f.keys().getEnumerator();while(c.moveNext()){var b=c.current();var d=$b($$a.$g.$type,b);if(d!=null&&d.content()!=null){var e=$b($.ig.ILegendContext.prototype.$type,d.content());if(e!=null&&e.itemLabel()==a.itemLabel()&&e.legendLabel()==a.legendLabel()&&e.series()==a.series()&&e.itemBrush()==a.itemBrush()){return true}}}return false},_k:null,_c:null,b:function(a){var b=this._h.rootWrapper().width();var c=this._h.rootWrapper().height();this._j.remove();var d=this._h.createElement("div");d.setStyleProperty("position","relative");this._k=this._h.createElement('<canvas style="position : absolute; top : 0; left : 0" />');this._k.setStyleProperty("position","absolute");this._k.setStyleProperty("top","0px");this._k.setStyleProperty("left","0px");this._h.append(d);d.append(this._k);this._c=new $.ig.RenderingContext(new $.ig.CanvasViewRenderer,this._h.get2DCanvasContext(this._k));this._k.setAttribute("width",b.toString());this._k.setAttribute("height",c.toString());return this._c},u:function(){return new $$a.af(1,this._h.rootWrapper().width(),Math.max(10,this._h.rootWrapper().height()-15))},t:function(a,b,c,d){var e=a.g();e.beginPath();e.moveTo(b._aj.__inner[0].__x,b._aj.__inner[0].__y);for(var f=1;f<b._aj.count();f++){e.lineTo(b._aj.__inner[f].__x,b._aj.__inner[f].__y)}e.lineTo(b._aj.__inner[0].__x,b._aj.__inner[0].__y);var g=e.createLinearGradient(d.left(),d.top(),d.left(),d.top()+d.height());var i=c._a.getEnumerator();while(i.moveNext()){var h=i.current();g.addColorStop(h._a,h._b.__fill)}e.fillStyle=g;e.fill()},o:function(){},p:function(){},$type:new $.ig.Type("LegendBaseViewManager",$.ig.$ot)},true);$c("LegendMouseEventArgs:b","EventArgs",{init:function(a,b,c,d,e){$$0.$w.init.call(this);this.chart(a);this.series(b);this.item(c);this.originalEvent(d);this.legendItem(e)},toString:function(){return this.chart().name()+", "+this.series().name()+", "+(this.item()!=null?this.item().toString():"")+", "+this.getPosition(null).toString()},_originalEvent:null,originalEvent:function(a){if(arguments.length===1){this._originalEvent=a;return a}else{return this._originalEvent}},getPosition:function(a){return this.originalEvent().getPosition(a)},originalSource:function(){return this.originalEvent().originalSource()},_item:null,item:function(a){if(arguments.length===1){this._item=a;return a}else{return this._item}},_series:null,series:function(a){if(arguments.length===1){this._series=a;return a}else{return this._series}},_chart:null,chart:function(a){if(arguments.length===1){this._chart=a;return a}else{return this._chart}},_legendItem:null,legendItem:function(a){if(arguments.length===1){this._legendItem=a;return a}else{return this._legendItem}},$type:new $.ig.Type("LegendMouseEventArgs",$$0.$w.$type)},true);$c("LegendMouseButtonEventArgs:d","EventArgs",{init:function(a,b,c,d,e){$$0.$w.init.call(this);this.chart(a);this.series(b);this.item(c);this.originalEvent(d);this.legendItem(e)},toString:function(){return this.chart().name()+", "+this.series().name()+", "+(this.item()!=null?this.item().toString():"")+", "+this.getPosition(null).toString()},_originalEvent:null,originalEvent:function(a){if(arguments.length===1){this._originalEvent=a;return a}else{return this._originalEvent}},handled:function(a){if(arguments.length===1){this.originalEvent().handled(a);return a}else{return this.originalEvent().handled()}},getPosition:function(a){return this.originalEvent().getPosition(a)},originalSource:function(){return this.originalEvent().originalSource()},_item:null,item:function(a){if(arguments.length===1){this._item=a;return a}else{return this._item}},_series:null,series:function(a){if(arguments.length===1){this._series=a;return a}else{return this._series}},_chart:null,chart:function(a){if(arguments.length===1){this._chart=a;return a}else{return this._chart}},_legendItem:null,legendItem:function(a){if(arguments.length===1){this._legendItem=a;return a}else{return this._legendItem}},$type:new $.ig.Type("LegendMouseButtonEventArgs",$$0.$w.$type)},true);$c("LegendBase:i","ContentControl",{aj:function(){return new $$t.l(this)},a5:function(a){this._ak=a},_ak:null,init:function(){$$a.$g.init.call(this);var a=this.aj();this.a5(a);a.x();this.children(new $$4.e($$a.$c.$type,0))},addChildInOrder:function(a,b){},az:function(a,b){},_children:null,children:function(a){if(arguments.length===1){this._children=a;return a}else{return this._children}},_seriesOwner:null,seriesOwner:function(a){if(arguments.length===1){this._seriesOwner=a;return a}else{return this._seriesOwner}},_chartOwner:null,chartOwner:function(a){if(arguments.length===1){this._chartOwner=a;return a}else{return this._chartOwner}},isItemwise:function(){return false},isScale:function(){return false},clearLegendItemsForSeries:function(a){if(a==null||this.children()==null||this.children().count()==0){return}var b=new $$4.e($$a.$c.$type,0);var d=this.children().getEnumerator();while(d.moveNext()){var c=d.current();var e=$b($$a.$g.$type,c);if(e!=null&&e.content()!=null){var f=$b($.ig.ILegendContext.prototype.$type,e.content());if(f!=null&&f.series()==a){b.add(c)}}}var h=b.getEnumerator();while(h.moveNext()){var g=h.current();this.children().remove(g)}},containsChild:function(a){return this.children().contains(a)},removeChild:function(a){this.children().remove(a)},ai:function(){if(this.seriesOwner()!=null){return this.seriesOwner()}else{return this.chartOwner()}},propertyChanged:null,propertyUpdated:null,a7:function(a,b,c){if(this.propertyChanged!=null){this.propertyChanged(this,new $$0.b8(a))}if(this.propertyUpdated!=null){this.propertyUpdated(this,new $.ig.PropertyUpdatedEventArgs(a,b,c))}},legendItemMouseLeftButtonDown:null,a2:function(a){if(this.legendItemMouseLeftButtonDown!=null){this.legendItemMouseLeftButtonDown(this,a)}},legendItemMouseLeftButtonUp:null,a3:function(a){if(this.legendItemMouseLeftButtonUp!=null){this.legendItemMouseLeftButtonUp(this,a)}},legendItemMouseEnter:null,a0:function(a){if(this.legendItemMouseEnter!=null){this.legendItemMouseEnter(this,a)}},legendItemMouseLeave:null,a1:function(a){if(this.legendItemMouseLeave!=null){this.legendItemMouseLeave(this,a)}},legendItemMouseMove:null,a4:function(a){if(this.legendItemMouseMove!=null){this.legendItemMouseMove(this,a)}},provideContainer:function(a){this._ak.w(a)},legendItemsListStyle:function(a){if(arguments.length===1){this._ak._j=a;return a}else{return this._ak._j}},legendItemStyle:function(a){if(arguments.length===1){this._ak._k=a;return a}else{return this._ak._k}},legendItemBadgeStyle:function(a){if(arguments.length===1){this._ak._i=a;return a}else{return this._ak._i}},legendItemTextStyle:function(a){if(arguments.length===1){this._ak._l=a;return a}else{return this._ak._l}},exportVisualData:function(){var a=new $$t.s;var c=this.children().getEnumerator();while(c.moveNext()){var b=c.current();var d=$b($$a.$g.$type,b);var e=new $$t.r;var f=$b($.ig.ILegendContext.prototype.$type,d.content());if(f!=null){if(f.itemLabel()!=null&&!String.isNullOrEmpty(f.itemLabel().toString())){e.label(f.itemLabel().toString())}if(f.legendLabel()!=null&&!String.isNullOrEmpty(f.legendLabel().toString())){e.label(f.legendLabel().toString())}if(f.actualItemBrush()!=null){e.appearance().fill($.ig.AppearanceHelper.prototype.b(f.actualItemBrush()))}else{e.appearance().fill($.ig.AppearanceHelper.prototype.b(f.itemBrush()))}}a.items().add(e)}return a},$type:new $.ig.Type("LegendBase",$$a.$g.$type,[$$0.$b7.$type,$.ig.IChartLegend.prototype.$type])},true);$c("ItemLegend:f","LegendBase",{aj:function(){return new $$t.k(this)},a5:function(a){$$t.$i.a5.call(this,a);this._a9=a},_a9:null,init:function(){var $self=this;$$t.$i.init.call(this);this._ab=$$t.$f.$type;var a=this.children();a.collectionChanged=$.ig.Delegate.prototype.combine(a.collectionChanged,function(a,b){if(b.oldItems()!=null){var d=b.oldItems().getEnumerator();while(d.moveNext()){var c=d.current();$self._a9.aa(c)}}if(b.newItems()!=null){var f=b.newItems().getEnumerator();while(f.moveNext()){var e=f.current();$self._a9.m(e)}}})},addChildInOrder:function(a,b){if(!this._ak.g()){return}this.be(b)},isItemwise:function(){return true},createItemwiseLegendItems:function(a,b){this.az(a,b)},az:function(a,b){this._ak.u();this.clearLegendItemsForSeries(b);if(b==null||a==null||a.count()==0){return}var d=a.getEnumerator();while(d.moveNext()){var c=d.current();var e=$b($$a.$g.$type,c);if(e!=null&&e.content()!=null){var f=$b($.ig.ILegendContext.prototype.$type,e.content());if(f!=null&&!this.bb(f)){this.children().add(c);var g=new $$t.h;g._b=f;g._c=c;g._a=b;if(f.legendLabel()!=null){g._d=f.legendLabel()}else{g._d=f.itemLabel()}}}}this._ak.v()},createLegendItemsInsert:function(a,b){this.bd(a,b)},bd:function(a,b){this._ak.u();var c=this.bc(b);if(b==null||a==null||a.count()==0){return}var e=a.getEnumerator();while(e.moveNext()){var d=e.current();var f=$b($$a.$g.$type,d);if(f!=null&&f.content()!=null){var g=$b($.ig.ILegendContext.prototype.$type,f.content());if(g!=null&&!this.bb(g)){this.children().insert(c,d);c++;var h=new $$t.h;h._b=g;h._c=d;h._a=b;h._d=g.legendLabel()!=null?g.legendLabel().toString():g.itemLabel()}}}this._ak.v()},renderItemwiseContent:function(a){this.be(a)},be:function(a){var $self=this;this.clearLegendItemsForSeries(a);if(a.hasSubItems()){a.forSubItems(function(b){var c=$b($$a.$g.$type,b);if(c!=null&&c.content()!=null){var d=$b($.ig.ILegendContext.prototype.$type,c.content());if(d!=null&&!$self.bb(d)){$self.children().add(b);var e=new $$t.h;e._b=d;e._c=b;e._a=a;e._d=d.itemLabel()}}})}},bc:function(a){if(a==null||this.children()==null||this.children().count()==0){return 0}var b=new $$4.e($$a.$c.$type,0);var c=-1;var d=0;var f=this.children().getEnumerator();while(f.moveNext()){var e=f.current();var g=$b($$a.$g.$type,e);if(g!=null&&g.content()!=null){var h=$b($.ig.ILegendContext.prototype.$type,g.content());if(h!=null&&h.series()==a){if(c==-1){c=d}b.add(e)}}d++}var j=b.getEnumerator();while(j.moveNext()){var i=j.current();this.children().remove(i)}if(c==-1){return this.children().count()}return c},bb:function(a){return this._a9.ac(a)},_ba:null,$type:new $.ig.Type("ItemLegend",$$t.$i.$type,[$.ig.IChartItemLegend.prototype.$type])},true);$c("Legend:g","LegendBase",{aj:function(){return new $$t.m(this)},a5:function(a){$$t.$i.a5.call(this,a);this._a9=a},_a9:null,init:function(){var $self=this;$$t.$i.init.call(this);this._ab=$$t.$g.$type;var a=this.children();a.collectionChanged=$.ig.Delegate.prototype.combine(a.collectionChanged,function(a,b){if(b.oldItems()!=null){var d=b.oldItems().getEnumerator();while(d.moveNext()){var c=d.current();$self._a9.aa(c)}}if(b.newItems()!=null){var f=b.newItems().getEnumerator();while(f.moveNext()){var e=f.current();$self._a9.m(e)}}})},ba:function(a){return a.resolveLegendIndex()},bc:function(a){return this.bb(a)},addChildInOrder:function(a,b){if(b.isStacked()){return}if(!b.isUsableInLegend()){return}var c=0;var e=this.children().getEnumerator();while(e.moveNext()){var d=e.current();var f;var g;var h;var i=this._ak.p(d,f,g,h);f=i.p1;g=i.p2;h=i.p3;if(b.container()!=null&&f!=null&&(this.bc(b.container())<this.bc(f)||this.bc(b.container())==-1&&this.bc(f)==-1&&b.container().getHashCode()<f.getHashCode())){break}if(b.container()!=null&&f!=null&&b.container()==f&&g!=null){var j=this.ba(b);var k=this.ba(g);var l=this.bc(b);var m=this.bc(g);if(g.isVertical()&&!g.isStacked()){if(m==-1&&l==-1){c=0;break}if(l<m||m==-1){break}}if(j<=k){break}}c++}this.children().insert(c,a);var n=new $$t.h;n._c=a;n._a=b;var o=$b($$a.$g.$type,a);if(o!=null&&o.content()!=null){var p=$b($.ig.ILegendContext.prototype.$type,o.content());if(p!=null){n._b=p;n._d=p.itemLabel()}}},bb:function(a){return-1},$type:new $.ig.Type("Legend",$$t.$i.$type)},true);$c("LegendItemInfo:h","Object",{init:function(){$.ig.$op.init.call(this)},_d:null,_c:null,_a:null,_b:null,$type:new $.ig.Type("LegendItemInfo",$.ig.$ot)},true);$c("ScaleLegend:j","LegendBase",{aj:function(){return new $$t.n(this)},a5:function(a){$$t.$i.a5.call(this,a);this._bb=a},_bb:null,legendScaleElement:function(){return this._bb._ax},minText:function(){return this._bb._at},maxText:function(){return this._bb._as},init:function(){$$t.$i.init.call(this);this._ab=$$t.$j.$type},_bd:0,_bc:0,a9:null,ba:function(a){if(arguments.length===1){this.a9=a;return a}else{return this.a9}},bg:function(){this._bb.ap()},restoreOriginalState:function(){this.bg()},bj:function(a){if(a==null){return this._bb.aw()}return $.ig.ColorUtil.prototype.m(a)},be:function(a){this.ba(a);this.bf()},initializeLegend:function(a){this.be(a)},isScale:function(){return true},bf:function(){var $self=this;if(this.legendScaleElement()==null||this.ba()==null||!this.ba().legendReady()){return}if(this.ba()==null||!this.ba().isAttachedTo(this)){return}var a=false;var b=$b($$a.$bw.$type,this.legendScaleElement());if(b!=null){var c=this._bb.aj();if(!this.ba().forScaleColors(function(d,e){$self._bb.al(c,$self.bj(d),e)})){a=true}this._bb.aq(b,a,c)}if(this.minText()!=null){this.minText().ak(this.ba().minScaleText())}if(this.maxText()!=null){this.maxText().ak(this.ba().maxScaleText())}},$type:new $.ig.Type("ScaleLegend",$$t.$i.$type,[$.ig.IChartScaleLegend.prototype.$type])},true);$c("LegendBaseView:l","Object",{init:function(a){this.f=false;$.ig.$op.init.call(this);this._a=a;this._b=new $$t.a(this)},_b:null,_a:null,x:function(){},e:function(){return false},c:function(a){var b;var c;var d;var e=this.p(a,b,c,d);b=e.p1;c=e.p2;d=e.p3;var f=new $$a.as;var g=new $$t.d(b,c,d,f,a);return g},d:function(a){var b;var c;var d;var e=this.p(a,b,c,d);b=e.p1;c=e.p2;d=e.p3;var f=new $$a.ar;var g=new $$t.b(b,c,d,f,a);return g},p:function(a,b,c,d){b=this._a.ai();c=null;d=null;if(a!=null){var e=$b($$a.$g.$type,a);if(e!=null&&e.content()!=null&&$b($.ig.ILegendContext.prototype.$type,e.content())!==null){var f=$b($.ig.ILegendContext.prototype.$type,e.content());c=$b($.ig.ILegendSeries.prototype.$type,f.series());if(c!=null){b=c.container()}d=f.item()}}return{p1:b,p2:c,p3:d}},o:function(){},g:function(){return true},n:function(a){},z:function(a){},w:function(a){this._b.q(a)},aa:function(a){this._b.s(a)},m:function(a){var b=this._a.children().indexOf(a);this._b.m(a,b)},u:function(){this._b.o()},v:function(){this._b.p()},_j:null,_k:null,_i:null,_l:null,f:false,y:function(){},h:function(e_){return this._b.l(e_)},s:function(a){if(!this.f){this._a.a0(this.d(this.h(a)))}this.f=true},r:function(a){if(this.f){this._a.a1(this.d(this.h(a)))}this.f=false},q:function(a){this._a.a2(this.c(this.h(a)))},t:function(a){this._a.a3(this.c(this.h(a)))},$type:new $.ig.Type("LegendBaseView",$.ig.$ot)},true);$c("ItemLegendView:k","LegendBaseView",{init:function(a){$$t.$l.init.call(this,a);this._ab=a},_ab:null,x:function(){$$t.$l.x.call(this)},e:function(){return true},ac:function(a){return this._b.e(a)},$type:new $.ig.Type("ItemLegendView",$$t.$l.$type)},true);$c("LegendView:m","LegendBaseView",{init:function(a){$$t.$l.init.call(this,a);this._ab=a},_ab:null,x:function(){$$t.$l.x.call(this)},$type:new $.ig.Type("LegendView",$$t.$l.$type)},true);$c("ScaleLegendView:n","LegendBaseView",{init:function(a){this._ay=new $$a.af;this.ae=false;$$t.$l.init.call(this,a);this._ac=a;this._at=new $$a.an;this._as=new $$a.an;this._ax=new $$a.bt},_ac:null,_ax:null,_at:null,_as:null,ap:function(){},o:function(){},aw:function(){return $$a.$ax.u(0,0,0,0)},aj:function(){return new $$t.o},al:function(a,b,c){var d=a;d._a.add(function(){var $ret=new $$t.p;$ret._b=function(){var $ret=new $$a.at;$ret.color(b);return $ret}();$ret._a=c;return $ret}())},aq:function(a,b,c){if(b){this._au=this._ac.ba().actualMarkerBrush();this._ab=null}else{this._au=null;this._ab=c;this._ab.b()}this.am()},_ab:null,_ad:null,_ay:null,w:function(a){$$t.$l.w.call(this,a);this._ad=this._b.b(a);this._ay=this._b.u();this.am()},ae:false,am:function(){if(!this.ae){this.ae=true;if(this._b._h!=null){this._b._h.setTimeout(this.ar.runOn(this),0)}else{window.setTimeout(this.ar.runOn(this),0)}}},ar:function(){if(this.ae){this.ae=false;this.ao()}},ao:function(){if(this._ad==null){return}this.an()},ah:function(a){var b=$b($$a.$an.$type,a);if(b!=null&&b.ak()!=null){return this._ad.e(b)+0}return 0},ag:function(a){return this._af+0},_af:0,_av:null,an:function(){if(this._ac.ba()==null||this._ac.ba().container()==null||this._ab==null&&this._au==null){return}if(this._ad.d()){var a=$b($.ig.IInternalLegendOwner.prototype.$type,this._ac.ba().container());this._ad.ac(a.getFontInfo());this._af=a.getFontHeight();this._av=a.getFontBrush();var b=this.ah(this._at);var c=this.ah(this._as);var d=Math.max(b,c)+4;if(d>=this._ay.width()){d=0}var e=this._ay.width()-d;var f=2;var g=2;e=e-4;var h=this._ay.height()-4;var i=f+e+4;var j=g;var k=h;var l={__x:f+3/5*e,__y:g,$type:$$a.$y.$type,getType:$.ig.$op.getType,getGetHashCode:$.ig.$op.getGetHashCode,typeName:$.ig.$op.typeName};var m={__x:f+5/5*e,__y:g,$type:$$a.$y.$type,getType:$.ig.$op.getType,getGetHashCode:$.ig.$op.getGetHashCode,typeName:$.ig.$op.typeName};var n={__x:f+5/5*e,__y:h,$type:$$a.$y.$type,getType:$.ig.$op.getType,getGetHashCode:$.ig.$op.getGetHashCode,typeName:$.ig.$op.typeName};var o={__x:f,__y:h,$type:$$a.$y.$type,getType:$.ig.$op.getType,getGetHashCode:$.ig.$op.getGetHashCode,typeName:$.ig.$op.typeName};var p=this._ax;p._aj.clear();p._aj.add(l);p._aj.add(m);p._aj.add(n);p._aj.add(o);this._at._n=i;this._at._o=j;this._at._am=this._av;this._as._n=i;this._as._o=j+k-this.ag(this._at);this._as._am=this._av;this._ad.k(0,0,this._ay.width(),this._ay.height());if(this._ab==null&&this._au!=null){p.__fill=this._au;this._ad.t(p)}else{this._b.t(this._ad,p,this._ab,new $$a.ae(0,g,f,e,h))}if(d>0){this._ad.w(this._at);this._ad.w(this._as)}}},_au:null,y:function(){$$t.$l.y.call(this)},$type:new $.ig.Type("ScaleLegendView",$$t.$l.$type)},true);$c("GradientData:o","Object",{init:function(){$.ig.$op.init.call(this);this._a=new $$4.w($$t.$p.$type,0)},_a:null,b:function(){this._a.sort2(function(a,b){return $w(a._a,b._a)})},$type:new $.ig.Type("GradientData",$.ig.$ot)},true);$c("GradientStopData:p","Object",{init:function(){$.ig.$op.init.call(this)},_a:0,_b:null,$type:new $.ig.Type("GradientStopData",$.ig.$ot)},true);$c("LegendItemVisualData:r","Object",{init:function(){$.ig.$op.init.call(this);this.labelBounds($.ig.RectData.prototype.empty());this.appearance(new $.ig.PrimitiveAppearanceData)},_label:null,label:function(a){if(arguments.length===1){this._label=a;return a}else{return this._label}},_labelBounds:null,labelBounds:function(a){if(arguments.length===1){this._labelBounds=a;return a}else{return this._labelBounds}},_appearance:null,appearance:function(a){if(arguments.length===1){this._appearance=a;return a}else{return this._appearance}},_labelAppearance:null,labelAppearance:function(a){if(arguments.length===1){this._labelAppearance=a;return a}else{return this._labelAppearance}},serialize:function(){var a=new $$6.aj(0);a.u("{");if(this.label()!=null){a.u('label: "'+this.label()+'", ')}if(this.appearance()!=null){a.u("appearance: "+this.appearance().serialize()+", ")}if(this.labelAppearance()!=null){a.u("labelAppearance: "+this.labelAppearance().serialize()+", ")}a.u("labelBounds: { left: "+this.labelBounds().left()+", top: "+this.labelBounds().top()+", width: "+this.labelBounds().width()+", height: "+this.labelBounds().height()+"}");a.u("}");return a.toString()},$type:new $.ig.Type("LegendItemVisualData",$.ig.$ot)},true);$c("LegendVisualDataList:q","List$1",{init:function(){$$4.$w.init.call(this,$$t.$r.$type,0)},$type:new $.ig.Type("LegendVisualDataList",$$4.$w.$type.specialize($$t.$r.$type))},true);$c("LegendVisualData:s","Object",{init:function(){$.ig.$op.init.call(this);this.items(new $$t.q)},_items:null,items:function(a){if(arguments.length===1){this._items=a;return a}else{return this._items}},_viewport:null,viewport:function(a){if(arguments.length===1){this._viewport=a;return a}else{return this._viewport}},_width:0,width:function(a){if(arguments.length===1){this._width=a;return a}else{return this._width}},_height:0,height:function(a){if(arguments.length===1){this._height=a;return a}else{return this._height}},serialize:function(){var a=new $$6.aj(0);a.u("{");a.u("width: "+this.width()+",");a.u("height: "+this.height()+",");a.u("items: [");for(var b=0;b<this.items().count();b++){if(b!=0){a.l(", ")}a.l(this.items().__inner[b].serialize())}a.u("],");a.u("}");return a.toString()},$type:new $.ig.Type("LegendVisualData",$.ig.$ot)},true)});(function(factory){if(typeof define==="function"&&define.amd){define("watermark",["jquery"],factory)}else{factory(jQuery)}})(function($){$(document).ready(function(){var wm=$("#__ig_wm__").length>0?$("#__ig_wm__"):$("<div id='__ig_wm__'></div>").appendTo(document.body);wm.css({position:"fixed",bottom:0,right:0,zIndex:1e3}).addClass("ui-igtrialwatermark")})});