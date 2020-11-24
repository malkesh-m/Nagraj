import { PagedFilterAndSortedRequest } from '../../dto/pagedFilterAndSortedRequest';

export interface PagedContactResultRequestDto extends PagedFilterAndSortedRequest  {
    keyword: string
}
