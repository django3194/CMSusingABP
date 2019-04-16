import { Vishnu_MyProjectTemplatePage } from './app.po';

describe('Vishnu_MyProject App', function() {
  let page: Vishnu_MyProjectTemplatePage;

  beforeEach(() => {
    page = new Vishnu_MyProjectTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
