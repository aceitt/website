<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <br /> <br /> <br /><br /><br />
    <div></div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="LeftColumnContent" Runat="Server">
    <div class="container marketing">

      <!-- Three columns of text below the carousel -->
   <%--   <div class="row">
        <div class="col-lg-4">
          <img class="img-circle" src="data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==" alt="Generic placeholder image" width="140">
          <h2>Learn</h2>
          <p>Unique opportunity to learn the scoped content that targets Indian education system. The courses are planned for all the grades. These sessions help you 
              succeed in your career.
          </p>
          <p><a class="btn btn-default" href="Courses.aspx" role="button">View courses &raquo;</a></p>
        </div><!-- /.col-lg-4 -->
        <div class="col-lg-4">
          <img class="img-circle" src="data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==" alt="Generic placeholder image" width="140" height="140">
          <h2>Measure</h2>
          <p>We have tens of tests available for each course. These tests measure the skills acquired in the subject area. Our system suggests you unique ways to fill the gaps in each area.</p>
          <p><a class="btn btn-default" href="#" role="button">View tests &raquo;</a></p>
        </div><!-- /.col-lg-4 -->
        <div class="col-lg-4">
          <img class="img-circle" src="data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==" alt="Generic placeholder image" width="140" height="140">
          <h2>Share</h2>
          <p>Our forums allows you to interact with the teachers, and other students, and helps you when stuck. Don't forget to share about us with your friends, and earn rewards.</p>
          <p>
            <a href="http://www.facebook.com/sharer.php?u=projectchanakya.azurewebsites.net/" class="btn btn-social btn-facebook link-in-popup">
          <i class="fa fa-facebook pull-right"></i> Share on Facebook</button> </a></p>
        </div>--%><!-- /.col-lg-4 -->
      </div><!-- /.row -->


      <!-- START THE FEATURETTES 

      <hr class="featurette-divider">

      <div class="row featurette">
        <div class="col-md-7">
          <h2 class="featurette-heading">First featurette heading. <span class="text-muted">It'll blow your mind.</span></h2>
          <p class="lead">Donec ullamcorper nulla non metus auctor fringilla. Vestibulum id ligula porta felis euismod semper. Praesent commodo cursus magna, vel scelerisque nisl consectetur. Fusce dapibus, tellus ac cursus commodo.</p>
        </div>
        <!--<div class="col-md-5">
          <img class="featurette-image img-responsive center-block" data-src="holder.js/500x500/auto" alt="Generic placeholder image">
        </div>
      </div>-->
        <!--
      <hr class="featurette-divider">

      <div class="row featurette">
        <div class="col-md-7 col-md-push-5">
          <h2 class="featurette-heading">Oh yeah, it's that good. <span class="text-muted">See for yourself.</span></h2>
          <p class="lead">Donec ullamcorper nulla non metus auctor fringilla. Vestibulum id ligula porta felis euismod semper. Praesent commodo cursus magna, vel scelerisque nisl consectetur. Fusce dapibus, tellus ac cursus commodo.</p>
        </div>
        <div class="col-md-5 col-md-pull-7">
          <img class="featurette-image img-responsive center-block" data-src="holder.js/500x500/auto" alt="Generic placeholder image">
        </div>
      </div>

      <hr class="featurette-divider">

      <div class="row featurette">
        <div class="col-md-7">
          <h2 class="featurette-heading">And lastly, this one. <span class="text-muted">Checkmate.</span></h2>
          <p class="lead">Donec ullamcorper nulla non metus auctor fringilla. Vestibulum id ligula porta felis euismod semper. Praesent commodo cursus magna, vel scelerisque nisl consectetur. Fusce dapibus, tellus ac cursus commodo.</p>
        </div>
        <div class="col-md-5">
          <img class="featurette-image img-responsive center-block" data-src="holder.js/500x500/auto" alt="Generic placeholder image">
        </div>
      </div>

      <hr class="featurette-divider">

      <!-- /END THE FEATURETTES -->


      <!-- FOOTER 
      <footer>
        <p class="pull-right"><a href="#">Back to top</a></p>  
        <!-- <a href="http://www.facebook.com/sharer.php?u=projectchanakya.azurewebsites.net/" class="btn btn-social btn-facebook link-in-popup">
          <button type="button" class="btn btn-fb"><i class="fa fa-facebook pull-right"></i> Share on Facebook</button> </a>
      </footer>-->

    </div><!-- /.container -->  

     <!--Banner Wrap Start-->
    <div class="gt_banner default_width">
        <div class="swiper-container" id="swiper-container">
             <ul class="swiper-wrapper">
                <li class="swiper-slide">
                    <img src="extra-images/banner-01.jpg" alt="">
                    <div class="gt_banner_text gt_slide_1">
                        <h3>Welcome to</h3>
                        <h2>AceItt test center</h2>
                    </div>
                </li>
                <li class="swiper-slide">
                    <img src="extra-images/banner-02.jpg" alt="">
                    <div class="gt_banner_text gt_slide_2">
                        <h3>Learning &#38; fun</h3>
                        <h2>Perfect Education</h2>
                        <a href="#">see More</a>
                        <a href="#">Buy Now!</a>
                    </div>
                </li>
                <li class="swiper-slide">
                    <img src="extra-images/banner-03.jpg" alt="">
                    <div class="gt_banner_text gt_slide_3">
                        <h3>We will take care</h3>
                        <h2>for your kids</h2>
                        <a href="#">see More</a>
                        <a href="#">Buy Now!</a>
                    </div>
                </li>
             </ul>
         </div>
        <div class="swiper-button-next"><i class="fa fa-angle-right"></i></div>
        <div class="swiper-button-prev"><i class="fa fa-angle-left"></i></div>
    </div>
    <!--Banner Wrap End-->

    <!--Main Content Wrap Start-->
    <div class="gt_main_content_wrap">
        <!--Banner Services Wrap Start-->
        <div class="gt_servicer">
            <div class="container">
                <div class="row">
                    <div class="col-md-3">
                        <div class="gt_main_services bg_1">
                            <i class="icon-write-board"></i>
                            <h5>Tests</h5>
                            <p>Hundreds of tests, and thousands of unique questions in each test. </p>
                            <a  class="bg_1" href="#"> <i class="fa fa-arrow-right"></i></a>
                        </div>
                    </div>
                    
                    <div class="col-md-3">
                        <div class="gt_main_services bg_2">
                            <i class="icon-teacher-showing-on-whiteboard"></i>
                            <h5>On call Teachers</h5>
                            <p>24 X 7 on call teacher support to clarify student's questions round the clock.<br /> </p>
                             <a class="bg_2" href="#"> <i class="fa fa-arrow-right"></i></a>
                        </div>
                    </div>
                    
                    <div class="col-md-3">
                        <div class="gt_main_services bg_4">
                            <i class="icon-number-blocks"></i>
                            <h5>Enrichment</h5>
                            <p>Enrichment programs those build foundation of skills and critical thinking. </p>
                              <a class="bg_4" href="#"> <i class="fa fa-arrow-right"></i></a>
                            
                        </div>
                    </div>
                    <div class="col-md-3">
                        <div class="gt_main_services bg_3">
                            <i class="icon-write-board"></i>
                            <h5>Rewards</h5>
                            <p>Engage students by recognizing their acheivement through rewards.</p>
                            <a  class="bg_3" href="#"> <i class="fa fa-arrow-right"></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--Banner Services Wrap End-->
        
        <!--Offer Wrap start-->
        <section class="gt_wht_offer_bg">
            <div class="container">
            	<div class="gt_hdg_1">
                    <h3>WHAT WE OFFER</h3>
                    <p>Online training and testing packages with rewards and ranking system.</span>
                    </p>
                    <span><img src="images/hdg-01.png" alt=""></span>
                </div>
                <!--What We Offer 2 Wrap Start-->
                <div class="row">
                    <div class="col-md-4 col-sm-6">
                        <div class="gt_wht_offer_wrap mb">
                            <i class="icon-meat bg_1"></i>
                            <div class="gt_wht_offer_des">
                                <h5><a href="#">Vedic Mathematics</a></h5>
                                <span class="bg_offer_1"></span>
                                <p>Train solve several mathematics problems easy, precise, and fast.</p>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-6">
                        <div class="gt_wht_offer_wrap mb">
                            <i class="icon-pencil bg_2"></i>
                            <div class="gt_wht_offer_des">
                                <h5><a href="#">Gifted Test Prep</a></h5>
                                <span class="bg_offer_2"></span>
                                <p>Math and aptitude test-taking practice and skill building for gifted program entrance exams.</p>
                            </div>
                        </div>
                    </div>
                   
                    <div class="col-md-4 col-sm-6">
                        <div class="gt_wht_offer_wrap mb">
                            <i class="icon-translation bg_4"></i>
                            <div class="gt_wht_offer_des">
                                <h5><a href="#">Class Room curriculum</a></h5>
                                <span class="bg_offer_4"></span>
                                <p>Online training according to the class room syllabus.</p>
                            </div>
                        </div>
                    </div>
                </div>
                <!--What We Offer 2 Wrap End-->
            </div>
        </section>
        <!--offer Wrap End-->
        
        <!--Facts and Figure Wrap End-->
        <section class="fact_figure_bg">
            <div class="container">
                <div class="gt_hdg_1 white_hdg">
                    <h3>Facts And Figure about AceItt testing</h3>
                    <p>Aenean commodo ligula eget dolor. Aenean massa. <span>elit, eget nibh etlibura.</span>
                    </p>
                    <span><img src="images/hdg-01.png" alt=""></span>
                </div>
                <div class="row">
                     <div class="col-md-3 col-sm-6">
                        <div class="gt_facts_wrap">
                            <h2 class="counter">1500</h2>
                            <span>Students</span>
                        </div>
                        <span class="facts_border bg_4"></span>
                    </div>
                    <div class="col-md-3 col-sm-6">
                        <div class="gt_facts_wrap">
                            <h2 class="counter">100</h2>
                            <span>Subjects</span>
                         </div>
                         <span class="facts_border bg_1"></span>
                    </div>

                    <div class="col-md-3 col-sm-6">
                        <div class="gt_facts_wrap">
                            <h2 class="counter">1000</h2>
                            <span>Questions per test</span>
                         </div>
                         <span class="facts_border bg_2"></span>
                    </div>    
                    <div class="col-md-3 col-sm-6">
                        <div class="gt_facts_wrap">
                            <h2 class="counter">1500</h2>
                            <span>Tests</span>
                        </div>
                        <span class="facts_border bg_3"></span>
                    </div>               
                </div>
                <div class="gt_fact_link_wrap default_width">
                    <a class="button_style_1 btn_lg" href="#">See more</a>
                    <a class="button_style_1 btn_lg" href="#">Buy Now!</a>
                </div>
            </div>
        </section>
        <!--Facts and Figure Wrap End-->

        <!--Popular Courses Wrap End-->

        <!--Our Gallery Wrap Start-->
        <!--Our Gallery Wrap End-->



        <!--Testimonial Wrap Start-->
        <section class="gt_testimonial_bg">
            <div class="container">
                <!--Main Heading Wrap Start-->
                <div class="gt_hdg_1 white_hdg">
                    <h3>what clients say about Us</h3>
                    <p>Here is what parents say in their own words.</span>
                    </p>
                    <span><img src="images/hdg-01.png" alt=""></span>
                </div>
                <!--Main Heading Wrap End-->

                <!--Testimonial 02 List Wrap Start-->
                <div class="gt_testimonial2_slider" id="gt_testimonial2_slider">
                    <div class="item">
                        <div class="gt_testi2_wrap">
                            <p>My kid after taking the class doing math 5x faster than before. Thank you AceItt, you rock!!!</p>
                            <div class="gt_testi2_detail">
                                <div class="gt_testi2_name">
                                    <h6>Raman</h6>
                                    <span>Parents</span>
                                </div>
                                <figure>
                                    <img src="extra-images/comment-02.jpg" alt="">
                                </figure>
                            </div>
                        </div>
                    </div>
                    <div class="item">
                        <div class="gt_testi2_wrap">
                            <p>My son now boasts that he can beat calculator in simple math. You truly taken his confidence next level.</p>
                            <div class="gt_testi2_detail">
                                <div class="gt_testi2_name">
                                    <h6>Deepa</h6>
                                    <span>Parents</span>
                                </div>
                                <figure>
                                    <img src="extra-images/comment-01.jpg" alt="">
                                </figure>
                            </div>
                        </div>
                    </div>
                    <div class="item">
                        <div class="gt_testi2_wrap">
                            <p>Doing tests here is now a habit for my daughter. Why not, as she is being recognized and rewarded.</p>
                            <div class="gt_testi2_detail">
                                <div class="gt_testi2_name">
                                    <h6>Sriram</h6>
                                    <span>Parents</span>
                                </div>
                                <figure>
                                    <img src="extra-images/comment-03.jpg" alt="">
                                </figure>
                            </div>
                        </div>
                    </div>
                    
                </div>
                <!--Testimonial 02 List Wrap End-->

            </div>
        </section>
        <!--Testimonial Wrap End-->

        <!--Our Client Wrap Start-->
        <section>
            <div class="container">
                <!--Main Heading Wrap Start-->
                <div class="gt_hdg_1">
                    <h3>Our Sponsors</h3>
                    <p>Thank you for being our sponsors. <span></span>
                    </p>
                    <span><img src="images/hdg-01.png" alt=""></span>
                </div>
                <!--Main Heading Wrap End-->
                
                <!--Brand List Wrap Start-->
                <div class="gt_brand_carousel owl-carouse">
                    <div class="item">
                        <div class="gt_brand_outer_wrap">
                            <a href="#"><img src="images/brand-01.jpg" alt=""></a>
                        </div>
                    </div>
                    <div class="item">
                        <div class="gt_brand_outer_wrap">
                            <a href="#"><img src="images/brand-02.jpg" alt=""></a>
                        </div>
                    </div>
                    <div class="item">
                        <div class="gt_brand_outer_wrap">
                            <a href="#"><img src="images/brand-03.jpg" alt=""></a>
                        </div>
                    </div>
                    <div class="item">
                        <div class="gt_brand_outer_wrap">
                            <a href="#"><img src="images/brand-04.jpg" alt=""></a>
                        </div>
                    </div>
                    <div class="item">
                        <div class="gt_brand_outer_wrap">
                            <a href="#"><img src="images/brand-05.jpg" alt=""></a>
                        </div>
                    </div>
                    <div class="item">
                        <div class="gt_brand_outer_wrap">
                            <a href="#"><img src="images/brand-06.jpg" alt=""></a>
                        </div>
                    </div>
                    <div class="item">
                        <div class="gt_brand_outer_wrap">
                            <a href="#"><img src="images/brand-01.jpg" alt=""></a>
                        </div>
                    </div>
                </div>
                <!--Brand List Wrap End-->
                
            </div>
        </section>
        <!--Our Client Wrap End-->
    </div>
    <!--Main Content Wrap End-->
    
    <!--Footer Wrap Start-->
    <footer>
        <!--NewsLetter Wrap Start-->
        <div class="gt_newsltr_bg default_width">
            <div class="container">
                <div class="row">
                    <div class="col-md-3"></div>
                    <div class="col-md-9">
                        <div class="gt_newsltr_wrap">
                            <form>
                                <input type="text" placeholder="Enter your email">
                                <input class="button_style_1 btn_lg" type="submit" value="Subscribe">
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--NewsLetter Wrap End-->

        <!--Footer Wrap Start-->
        <div class="gt_footer_bg default_width">
            <div class="container">
                <div class="row">
                    <div class="col-md-3">
                        <div class="gt_office_wrap default_width">
                            <div class="gt_office_time widget">
                                <h5>Opening Hour</h5>
                                <ul>
                                    <li>
                                        Monday - Sunday
                                        <span>24 X 7</span>
                                    </li>
                                </ul>
                            </div>
                            <div class="gt_foo_about widget">
                                <h5>About AceITT</h5>
                                <p>Online education and training platform.</p>
                                <ul>
                                    <li><a href="#"><i class="fa fa-facebook"></i></a></li>
                                    <li><a href="#"><i class="fa fa-twitter"></i></a></li>
                                    <li><a href="#"><i class="fa fa-google-plus"></i></a></li>
                                    <li><a href="#"><i class="fa fa-pinterest"></i></a></li>
                                    <li><a href="#"><i class="fa fa-linkedin"></i></a></li>
                                </ul>
                            </div>
                        </div>
                    </div>

                    

                </div>
            </div>
        </div>
        <!--Footer Wrap End-->

        <!--Copyright Wrap Start-->
        <div class="copyright_bg default_width">
            <div class="container">
                <div class="copyright_wrap default_width">
                    <p>©copyrights<a href="#">aceitt.com</a>. All Right Reserved.</p>
                    <span>Designed By: <a href="#">ACEITT LLC</a></span>
                </div>
            </div>
        </div>  
        <!--Copyright Wrap End-->      
    </footer> 
    <!--Footer Wrap End-->
    <!--Back to Top Wrap Start-->
    <div class="back-to-top">
        <a href="#home"><i class="fa fa-angle-up"></i></a>
    </div>
    <!--Back to Top Wrap Start-->

</div>
<!--gt Wrapper End-->
</asp:Content>
        

    

