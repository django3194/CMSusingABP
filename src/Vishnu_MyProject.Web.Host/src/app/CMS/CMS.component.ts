import { Component, Injector, ViewChild } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { CMSServiceServiceProxy, ListResultDtoOfCMSContentListDTO, CMSContent} from '@shared/service-proxies/service-proxies';
import { PagedListingComponentBase, PagedRequestDto } from 'shared/paged-listing-component-base';


@Component({
    templateUrl: './CMS.component.html',
    animations: [appModuleAnimation()]
})
export class CMSComponent extends PagedListingComponentBase<CMSContent> {
    protected delete(entity: CMSContent): void {
        throw new Error("Method not implemented.");
    }

    pageName : string = "test";
    active: boolean = false;
    contents: CMSContent[] = [];
    includeCanceledEvents: boolean = false;

    constructor(
        injector: Injector,
        private _cmsService: CMSServiceServiceProxy
    ) {
        super(injector);
    }

    protected list(request: PagedRequestDto, pageNumber: number, finishedCallback: Function): void {
        this.loadEvent();
        finishedCallback();
    }

    loadEvent() {
        this._cmsService.getAll()
            .subscribe((result: ListResultDtoOfCMSContentListDTO) => {
                this.contents = result.items;
            });
    }
}