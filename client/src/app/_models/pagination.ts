export interface Pagination {
  currentPage: number;
  itemsPerPage: number;
  totalItems: number;
  totalPages: number;
}
//                          Members[]
export class PaginatedResult<T>{
  result: T;
  pagination: Pagination;
}
