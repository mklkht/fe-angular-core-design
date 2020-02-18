import { FE-practiceTemplatePage } from './app.po';

describe('FE-practice App', function() {
  let page: FE-practiceTemplatePage;

  beforeEach(() => {
    page = new FE-practiceTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
