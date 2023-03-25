import { FanuunSolutionTemplatePage } from './app.po';

describe('FanuunSolution App', function() {
  let page: FanuunSolutionTemplatePage;

  beforeEach(() => {
    page = new FanuunSolutionTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
